using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Controller.EntryControls;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller
{
    public partial class StudentManagement : UserControl
    {
        public StudentManagement()
        {
            InitializeComponent();
            Theme.ApplyDataGridViewTheme(dgvStudents);
            StudentsReader();
        }

        public void StudentsReader()
        {
            var repo = new RepositoryStudentFile();
            dgvStudents.DataSource = repo.GetStudents();
            dgvStudents.Refresh();
        }

        private void studentAdd_Click(object sender, EventArgs e)
        {
            ShowUserControl(new StudentAdd());
        }

        private void studentEdit_Click(object sender, EventArgs e)
        {
            if (NoSelection()) return;

            try
            {
                // Safely parse Student ID
                if (!long.TryParse(dgvStudents.SelectedRows[0].Cells[0].Value?.ToString(), out long studentId))
                {
                    MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string firstName = dgvStudents.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                string middleName = dgvStudents.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
                string lastName = dgvStudents.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
                string course = dgvStudents.SelectedRows[0].Cells[4].Value?.ToString() ?? "";

                // Use TryParse for YearLevel to prevent errors
                int yearLevel = int.TryParse(dgvStudents.SelectedRows[0].Cells[5].Value?.ToString(), out int yl) ? yl : 0;

                string remarks = dgvStudents.SelectedRows[0].Cells[6].Value?.ToString() ?? "";
                string status = dgvStudents.SelectedRows[0].Cells[7].Value?.ToString() ?? "";

                StudentEdit studentEdit = new StudentEdit(studentId, firstName, middleName, lastName, course, yearLevel, remarks, status);

                // Ensure the UserControl is properly initialized
                if (studentEdit == null)
                {
                    MessageBox.Show("Failed to initialize StudentEdit UserControl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ShowUserControl(studentEdit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentDelete_Click(object sender, EventArgs e)
        {
            if (NoSelection()) return;

            var confirmation = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                var repo = new RepositoryStudentFile();

                // Ensure ID is parsed correctly before passing it to delete function
                if (long.TryParse(dgvStudents.SelectedRows[0].Cells[0].Value?.ToString(), out long studentId))
                {
                    repo.DeleteStudent(studentId);
                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentsReader();
                }
                else
                {
                    MessageBox.Show("Failed to delete student. Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper method to add and show a UserControl
        private void ShowUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Visible = true;
        }

        private bool NoSelection()
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void Students_ControlRemoved(object sender, ControlEventArgs e)
        {
            StudentsReader();
        }
    }
}
