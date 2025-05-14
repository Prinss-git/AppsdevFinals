using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.EnrollmentControls
{
    public partial class ViewEnrolledStudents : UserControl
    {
        public ViewEnrolledStudents()
        {
            InitializeComponent();
            Theme.ApplyDataGridViewTheme(dgvEnrolledStudents);
            LoadEnrolledStudents();
        }

        private void LoadEnrolledStudents()
        {
            var repo = new RepositoryEnrollmentHeaderFile();
            var enrolledStudents = repo.GetAllEnrollmentHeaders();
            dgvEnrolledStudents.DataSource = enrolledStudents;
            dgvEnrolledStudents.Refresh();
        }


        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (NoSelection()) return;

            var confirmation = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                var repo = new RepositoryEnrollmentHeaderFile();

                // Ensure ID is parsed correctly before passing it to delete function
                if (long.TryParse(dgvEnrolledStudents.SelectedRows[0].Cells["ENRHFSTUDID"].Value?.ToString(), out long studentId))
                {
                    var result = repo.DeleteEnrollmentHeader(studentId);
                    if (result.Success)
                    {
                        MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEnrolledStudents();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete student: {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to delete student. Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool NoSelection()
        {
            if (dgvEnrolledStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

    }
}
