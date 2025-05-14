using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Parnada_Appsdev.Models;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.SubjectPreqControls
{
    public partial class SubjectPreqAdd : Form
    {
        public SubjectPreqAdd()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validator.ValidateControls(this))
                {
                    MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RepositorySubjectPreq repository = new RepositorySubjectPreq();

                SubjectPreqFile newPreq = new SubjectPreqFile
                {
                    SUBJCODE = tbSubjectCode.Text.Trim(),
                    SUBJPRECODE = tbSubjectPreqCode.Text.Trim(),
                    SUBJCATEGORY = cboSubjectCategory.SelectedIndex == 0 ? "CR" : "PR"
                };

                // Check for duplicate primary key before adding
                if (repository.IsSubjectPreqExists(newPreq.SUBJCODE, newPreq.SUBJPRECODE))
                {
                    MessageBox.Show("This prerequisite subject already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isSave = repository.AddSubjectPreq(newPreq);

                if (isSave)
                {
                    MessageBox.Show("Prerequisite subject added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Validator.ClearControls(this);
                }
                else
                {
                    MessageBox.Show("Failed to add prerequisite subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
