using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Parnada_Appsdev.Models;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.SubjectPreqControls
{
    public partial class SubjectPreqEdit : Form
    {
        private string subjCode;
        private string subjPreCode;
        private string subjCategory;
        private Dictionary<string, string> categoryMap = new Dictionary<string, string>
        {
            { "Co-Requisite", "CR" },
            { "Pre-Requisite", "PR" }
        };

        private Dictionary<string, string> reverseCategoryMap = new Dictionary<string, string>
        {
            { "CR", "Co-Requisite" },
            { "PR", "Pre-Requisite" }
        };

        public SubjectPreqEdit(string subjCode, string subjPreCode, string subjCategory)
        {
            InitializeComponent();
            tbSubjectCode.Text = subjCode;
            tbSubjectPreqCode.Text = subjPreCode;

            // Set the combo box selection based on the 2-letter category code
            if (reverseCategoryMap.ContainsKey(subjCategory))
            {
                cboSubjectCategory.SelectedItem = reverseCategoryMap[subjCategory];
            }
            else
            {
                cboSubjectCategory.SelectedIndex = -1; // Default to no selection if invalid
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboSubjectCategory.SelectedItem != null)
            {
                string selectedCategory = cboSubjectCategory.SelectedItem.ToString();
                string categoryCode = categoryMap.ContainsKey(selectedCategory) ? categoryMap[selectedCategory] : string.Empty;

                var subjectPreq = new SubjectPreqFile
                {
                    SUBJCODE = tbSubjectCode.Text,
                    SUBJPRECODE = tbSubjectPreqCode.Text,
                    SUBJCATEGORY = categoryCode // Save as "CR" or "PR"
                };

                var repo = new RepositorySubjectPreq();
                bool isUpdated = repo.UpdateSubjectPreq(subjectPreq);

                if (isUpdated)
                {
                    MessageBox.Show("Subject prerequisite updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update subject prerequisite.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
