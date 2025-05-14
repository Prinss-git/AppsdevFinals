using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Controller.EnrollmentControls;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller
{
    public partial class EnrollmentManagement : UserControl
    {
        public EnrollmentManagement()
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

        private void btnViewEnrolledStudents_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ViewEnrolledStudents());
        }

        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to enroll.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Safely parse Student ID
                if (!long.TryParse(dgvStudents.SelectedRows[0].Cells[0].Value?.ToString(), out long studentId))
                {
                    MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Pass only the student ID to EnrollStudent UserControl
                EnrollStudent enrollStudent = new EnrollStudent(studentId);

                ShowUserControl(enrollStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enrolling student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewEnrollmentDetail_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to view enrollment details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Safely parse Student ID
                if (!long.TryParse(dgvStudents.SelectedRows[0].Cells[0].Value?.ToString(), out long studentId))
                {
                    MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Pass only the student ID to ViewEnrollmentDetail UserControl
                ViewEnrollmentDetail viewEnrollmentDetail = new ViewEnrollmentDetail(studentId);

                ShowUserControl(viewEnrollmentDetail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error viewing enrollment details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Show the UserControl
        private void ShowUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Visible = true;
        }

    }
}
