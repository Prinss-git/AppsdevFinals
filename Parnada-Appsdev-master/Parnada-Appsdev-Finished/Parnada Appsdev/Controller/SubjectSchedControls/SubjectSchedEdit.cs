using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Models.Parnada_Appsdev.Models;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.SubjectSchedControls
{
    public partial class SubjectSchedEdit : UserControl
    {
        private string edpCode;
        private string subjectCode;
        private DateTime startTime;
        private DateTime endTime;
        private string days;
        private string room;
        private int maxSize;
        private int classSize;
        private string status;
        private string xm;
        private string section;
        private int schoolYear;

        public SubjectSchedEdit(string edpCode, string subjectCode, DateTime startTime, DateTime endTime, string days, string room, int maxSize, int classSize, string status, string xm, string section, int schoolYear)
        {
            InitializeComponent();

            // Assign values directly to textboxes and controls
            tbEdpCode.Text = edpCode;
            tbSubjectCode.Text = subjectCode;
            dtpStartTime.Value = startTime;
            dtpEndTime.Value = endTime;
            tbRoom.Text = room;
            numMaxSize.Value = maxSize;
            numClassSize.Value = classSize;
            tbSection.Text = section;
            dtpYear.Value = new DateTime(schoolYear, 1, 1); // Set year without affecting other date parts

            // Set selected item for combo boxes
            cboDays.SelectedItem = days;
            cboTimeFormat.SelectedItem = xm;

            // Map status to the corresponding item in cboStatus
            var statusMapping = new Dictionary<string, string>
            {
                { "AC", "Active" }, { "IN", "Inactive" }, { "DI", "Dissolved" },
                { "RE", "Restricted" }, { "CL", "Closed" }
            };

            if (statusMapping.TryGetValue(status, out string mappedStatus))
            {
                cboStatus.SelectedItem = mappedStatus;
            }
            else
            {
                cboStatus.SelectedItem = null; // or handle the case where the status is not found
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateControls(this))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                SSFDAYS = cboDays.SelectedItem?.ToString() ?? "",
                SSFROOM = tbRoom.Text,
                SSFMAXSIZE = (int)numMaxSize.Value,
                SSFCLASSSIZE = (int)numClassSize.Value,
                SSFSTATUS = statusCode, // Uses two-letter status code
                SSFXM = cboTimeFormat.SelectedItem?.ToString() ?? "",
                SSFSECTION = tbSection.Text,
                SSFSCHOOLYEAR = dtpYear.Value.Year
            };

            bool isSave = repository.UpdateSubjectSched(newSched);

            if (isSave)
            {
                MessageBox.Show("Subject schedule updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Validator.ClearControls(this);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("Failed to update subject schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
