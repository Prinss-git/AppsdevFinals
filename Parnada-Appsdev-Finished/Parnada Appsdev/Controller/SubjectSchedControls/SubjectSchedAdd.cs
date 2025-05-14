using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using Parnada_Appsdev.Models.Parnada_Appsdev.Models;
using Parnada_Appsdev.Repository;
using static System.Collections.Specialized.BitVector32;

namespace Parnada_Appsdev.Controller.SubjectSchedControls
{
    public partial class SubjectSchedAdd : UserControl
    {
        public SubjectSchedAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateControls();

                RepositorySubjectSched repository = new RepositorySubjectSched();

                // Mapping status to two-letter codes (C# 7.3 compatible)
                string selectedStatus = cboStatus.SelectedItem?.ToString() ?? "";
                string statusCode = new Dictionary<string, string>
                {
                    { "Active", "AC" }, { "Inactive", "IN" }, { "Dissolved", "DI" },
                    { "Restricted", "RE" }, { "Closed", "CL" }
                }.TryGetValue(selectedStatus, out string code) ? code : "UN";

                SubjectSchedFile newSched = new SubjectSchedFile
                {
                    SSFEDPCODE = tbEdpCode.Text,
                    SSFSUBJCODE = tbSubjectCode.Text,
                    SSFSTARTTIME = dtpStartTime.Value,
                    SSFENDTIME = dtpEndTime.Value,
                    SSFDAYS = dtpDays.SelectedItem?.ToString() ?? "",
                    SSFROOM = tbRoom.Text,
                    SSFMAXSIZE = (int)numMaxSize.Value,
                    SSFCLASSSIZE = (int)numClassSize.Value,
                    SSFSTATUS = statusCode, // Uses two-letter status code
                    SSFXM = cboTimeFormat.SelectedItem?.ToString() ?? "",
                    SSFSECTION = tbSection.Text,
                    SSFSCHOOLYEAR = dtpYear.Value.Year
                };

                // Check for duplicate primary key before adding
                if (repository.IsSubjectSchedExists(newSched.SSFEDPCODE))
                {
                    MessageBox.Show("This EDP Code already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check for time conflicts
                using (SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString()))
                {
                    string query = @"SELECT COUNT(*) FROM SubjectSchedFile 
                                   WHERE SSFDAYS = @SSFDAYS 
                                   AND SSFROOM = @SSFROOM
                                   AND (
                                       (@SSFSTARTTIME BETWEEN SSFSTARTTIME AND SSFENDTIME)
                                       OR (@SSFENDTIME BETWEEN SSFSTARTTIME AND SSFENDTIME)
                                       OR (SSFSTARTTIME BETWEEN @SSFSTARTTIME AND @SSFENDTIME)
                                   )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SSFDAYS", newSched.SSFDAYS);
                        cmd.Parameters.AddWithValue("@SSFROOM", newSched.SSFROOM);
                        cmd.Parameters.AddWithValue("@SSFSTARTTIME", newSched.SSFSTARTTIME);
                        cmd.Parameters.AddWithValue("@SSFENDTIME", newSched.SSFENDTIME);

                        conn.Open();
                        int conflictCount = (int)cmd.ExecuteScalar();

                        if (conflictCount > 0)
                        {
                            MessageBox.Show("Time conflict detected! This schedule conflicts with an existing schedule in the same room and day. Please adjust the time or room.",
                                "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                bool isSave = repository.AddSubjectSched(newSched);

                if (isSave)
                {
                    MessageBox.Show("Subject schedule added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Validator.ClearControls(this);
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    MessageBox.Show("Failed to add subject schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateControls()
        {
            if (!Validator.ValidateControls(this))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbEdpCode.Text.Length > 8)
            {
                MessageBox.Show("EDP code cannot exceed 8 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbSubjectCode.Text.Length > 15)
            {
                MessageBox.Show("Subject code cannot exceed 15 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbRoom.Text.Length > 3)
            {
                MessageBox.Show("Room code cannot exceed 3 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbSection.Text.Length > 3)
            {
                MessageBox.Show("Section code cannot exceed 3 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

    }
}