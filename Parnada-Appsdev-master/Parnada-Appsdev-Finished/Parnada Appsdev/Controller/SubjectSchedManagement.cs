using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Controller.EntryControls;
using Parnada_Appsdev.Controller.SubjectSchedControls;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller
{
    public partial class SubjectSchedManagement : UserControl
    {
        public SubjectSchedManagement()
        {
            InitializeComponent();
            Theme.ApplyDataGridViewTheme(dgvSubjectSched);
            SubjectSchedReader();
        }

        private void SubjectSchedReader()
        {
            var repo = new RepositorySubjectSched();
            dgvSubjectSched.DataSource = repo.GetSubjectsSched();
            dgvSubjectSched.Refresh();
        }

        private void btnSubjectSchedAdd_Click(object sender, EventArgs e)
        {
            ShowUserControl(new SubjectSchedAdd());
        }

        private void btnSubjectSchedEdit_Click(object sender, EventArgs e)
        {
            if (NoSelection()) return;

            try
            {
                // Retrieve data from selected row
                string edpCode = dgvSubjectSched.SelectedRows[0].Cells["SSFEDPCODE"].Value?.ToString() ?? "";
                string subjectCode = dgvSubjectSched.SelectedRows[0].Cells["SSFSUBJCODE"].Value?.ToString() ?? "";
                DateTime startTime = Convert.ToDateTime(dgvSubjectSched.SelectedRows[0].Cells["SSFSTARTTIME"].Value);
                DateTime endTime = Convert.ToDateTime(dgvSubjectSched.SelectedRows[0].Cells["SSFENDTIME"].Value);
                string days = dgvSubjectSched.SelectedRows[0].Cells["SSFDAYS"].Value?.ToString() ?? "";
                string room = dgvSubjectSched.SelectedRows[0].Cells["SSFROOM"].Value?.ToString() ?? "";
                int maxSize = Convert.ToInt32(dgvSubjectSched.SelectedRows[0].Cells["SSFMAXSIZE"].Value);
                int classSize = Convert.ToInt32(dgvSubjectSched.SelectedRows[0].Cells["SSFCLASSSIZE"].Value);
                string status = dgvSubjectSched.SelectedRows[0].Cells["SSFSTATUS"].Value?.ToString() ?? "";
                string xm = dgvSubjectSched.SelectedRows[0].Cells["SSFXM"].Value?.ToString() ?? "";
                string section = dgvSubjectSched.SelectedRows[0].Cells["SSFSECTION"].Value?.ToString() ?? "";
                int schoolYear = Convert.ToInt32(dgvSubjectSched.SelectedRows[0].Cells["SSFSCHOOLYEAR"].Value);

                // Initialize the Edit UserControl with selected data
                SubjectSchedEdit subjectSchedEdit = new SubjectSchedEdit(edpCode, subjectCode, startTime, endTime, days, room, maxSize, classSize, status, xm, section, schoolYear);

                // Ensure the UserControl is properly initialized
                if (subjectSchedEdit == null)
                {
                    MessageBox.Show("Failed to initialize SubjectSchedEdit UserControl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Open the edit form or display the UserControl
                ShowUserControl(subjectSchedEdit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subject schedule data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSubjectSchedDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubjectSched.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the EDP code from the selected row
            string edpCode = dgvSubjectSched.SelectedRows[0].Cells["SSFEDPCODE"].Value.ToString();

            // Confirm deletion
            var confirmResult = MessageBox.Show($"Are you sure you want to delete the schedule with EDP Code: {edpCode}?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                RepositorySubjectSched repository = new RepositorySubjectSched();
                bool isDeleted = repository.DeleteSubjectSched(edpCode);

                if (isDeleted)
                {
                    MessageBox.Show("Schedule deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView
                    SubjectSchedReader();
                }
                else
                {
                    MessageBox.Show("Failed to delete schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ShowUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Visible = true;
        }

        private bool NoSelection()
        {
            if (dgvSubjectSched.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void SubjectSchedManagement_ControlRemoved(object sender, ControlEventArgs e)
        {
            SubjectSchedReader();
        }
    }
}
