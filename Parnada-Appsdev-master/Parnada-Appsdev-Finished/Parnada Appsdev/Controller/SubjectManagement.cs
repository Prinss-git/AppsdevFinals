using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Models;
using Parnada_Appsdev.Repository;
using Parnada_Appsdev.Controller.SubjectControls;

namespace Parnada_Appsdev.Controller.EntryControls
{
    public partial class SubjectManagement: UserControl
    {
        public SubjectManagement()
        {
            InitializeComponent();
            Theme.ApplyDataGridViewTheme(dgvSubjects);
            SubjectReader();
        }

        public void SubjectReader()
        {
            var repo = new RepositorySubjectFile();
            dgvSubjects.DataSource = repo.GetSubjects();
            dgvSubjects.Refresh();
        }

        private void ShowUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Visible = true;
        }

        private void subjectAdd_Click(object sender, EventArgs e)
        {
            ShowUserControl(new SubjectAdd());
        }

        private void subjectEdit_Click(object sender, EventArgs e)
        {
            if (NoSelection()) return;

            try
            {
                // Retrieve selected subject details
                string subjectCode = dgvSubjects.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
                string subjectDesc = dgvSubjects.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                int subjectUnits = int.TryParse(dgvSubjects.SelectedRows[0].Cells[2].Value?.ToString(), out int units) ? units : 0;
                string regOffered = dgvSubjects.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
                string category = dgvSubjects.SelectedRows[0].Cells[4].Value?.ToString() ?? "";
                string status = dgvSubjects.SelectedRows[0].Cells[5].Value?.ToString() ?? "";
                string courseCode = dgvSubjects.SelectedRows[0].Cells[6].Value?.ToString() ?? "";
                string curriculumCode = dgvSubjects.SelectedRows[0].Cells[7].Value?.ToString() ?? "";

                // Pass the data to SubjectEdit
                SubjectEdit subjectEdit = new SubjectEdit(subjectCode, subjectDesc, subjectUnits, regOffered, category, status, courseCode, curriculumCode);

                // Ensure the UserControl is properly initialized
                if (subjectEdit == null)
                {
                    MessageBox.Show("Failed to initialize SubjectEdit UserControl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ShowUserControl(subjectEdit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subject data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subjectDelete_Click(object sender, EventArgs e)
        {
            if (NoSelection()) return;

            var confirmation = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                var repo = new RepositorySubjectFile();

                // Ensure subject code is retrieved before passing it to delete function
                string subjectCode = dgvSubjects.SelectedRows[0].Cells[0].Value?.ToString();
                string courseCode = dgvSubjects.SelectedRows[0].Cells[6].Value?.ToString();

                if (!string.IsNullOrEmpty(subjectCode) && !string.IsNullOrEmpty(courseCode))
                {
                    repo.DeleteSubject(subjectCode, courseCode);
                    MessageBox.Show("Subject deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SubjectReader();
                }
                else
                {
                    MessageBox.Show("Failed to delete subject. Invalid subject code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //  Helper
        private bool NoSelection()
        {
            if (dgvSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void SubjectManagement_ControlRemoved(object sender, ControlEventArgs e)
        {
            SubjectReader();
        }
    }
}
