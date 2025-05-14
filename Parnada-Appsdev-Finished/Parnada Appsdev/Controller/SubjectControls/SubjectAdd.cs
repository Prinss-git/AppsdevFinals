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
    public partial class SubjectAdd : UserControl
    {
        public SubjectAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!Validator.ValidateControls(this))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var repo = new RepositorySubjectFile();

            // Mapping "Active"/"Inactive" to "AC"/"IN"
            var statusMapping = new Dictionary<string, string>
            {
                { "Active", "AC" },
                { "Inactive", "IN" }
            };

            // Get selected status and map it to code
            string selectedStatus = cboStatus.SelectedItem?.ToString() ?? "Inactive";
            string statusCode = statusMapping.ContainsKey(selectedStatus) ? statusMapping[selectedStatus] : "IN";

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

            try
            {
                bool isSaved = repo.AddSubject(subject);

                if (isSaved)
                {
                    MessageBox.Show("Subject saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Validator.ClearControls(this);
                }
                else
                {
                    MessageBox.Show("Failed to save subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Subject code already exists. Please use a unique subject code.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
