using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Models;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.SubjectControls
{
    public partial class SubjectEdit : UserControl
    {
        private string subjectCode;
        private string subjectDesc;
        private int subjectUnits;
        private string regOffered;
        private string category;
        private string status;
        private string courseCode;
        private string curriculumCode;

        public SubjectEdit(string subjectCode, string subjectDesc, int subjectUnits, string regOffered, string category, string status, string courseCode, string curriculumCode)
        {
            InitializeComponent();

            // Populate the UI fields
            tbSubjectCode.Text = subjectCode;
            tbDescription.Text = subjectDesc;
            numUnits.Value = subjectUnits;
            tbCurriculumCode.Text = curriculumCode;

            // Set combo box selections
            cboCategory.SelectedItem = category;
            cboCourseCode.SelectedItem = courseCode;

            // Convert regOffered value to match the combo box index
            cboOffering.SelectedIndex = regOffered == "1" ? 0 : 1;

            // Map status codes ("AC"/"IN") to display values ("Active"/"Inactive")
            var statusMapping = new Dictionary<string, string>
            {
                { "AC", "Active" },
                { "IN", "Inactive" }
            };

            if (statusMapping.ContainsKey(status))
            {
                cboStatus.SelectedItem = statusMapping[status];
            }
            else
            {
                cboStatus.SelectedIndex = -1; // Default to no selection if status is invalid
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateControls(this))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var repo = new RepositorySubjectFile();

            // Mapping "Active" -> "AC" and "Inactive" -> "IN"
            var statusMapping = new Dictionary<string, string>
            {
                { "Active", "AC" },
                { "Inactive", "IN" }
            };

            // Get selected status and map it to code
            string selectedStatus = cboStatus.SelectedItem?.ToString() ?? "Inactive"; // Default to "Inactive"
            string statusCode = statusMapping.TryGetValue(selectedStatus, out string mappedStatus) ? mappedStatus : "IN";

            SubjectFile subject = new SubjectFile
            {
                SFSUBJCODE = tbSubjectCode.Text,
                SFSUBJDESC = tbDescription.Text,
                SFSUBJUNITS = (int)numUnits.Value, 
                SFSUBJREGOFRNG = cboOffering.SelectedIndex == 0 ? 1 : 2,
                SFSUBJCATEGORY = cboCategory.Text,
                SFSUBJSTATUS = statusCode, // Stores "AC" or "IN" to the database
                SFSUBJCOURSECODE = cboCourseCode.Text,
                SFSUBJCURRCODE = tbCurriculumCode.Text
            };

            bool result = repo.UpdateSubject(subject);

            if (result)
            {
                MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Validator.ClearControls(this);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("Failed to update subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
