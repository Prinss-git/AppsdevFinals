using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Controller.GradingControl;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.EnrollmentControls
{
    public partial class ViewEnrollmentDetail : UserControl
    {
        private long studentId;

        public ViewEnrollmentDetail(long studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
            Theme.ApplyDataGridViewTheme(dgvEnrolledSubjects);
            Theme.ApplyDataGridViewTheme(dgvGradingSubjects);
            LoadEnrolledSubjects();
            LoadGradingSubjects();
        }

        private void LoadEnrolledSubjects()
        {
            var repo = new RepositoryEnrollmentHeaderFile();
            var dt = repo.GetEnrolledSubjects(studentId);
            dgvEnrolledSubjects.DataSource = dt;
            dgvEnrolledSubjects.Refresh();
        }

        private void LoadGradingSubjects()
        {
            var repo = new RepositoryStudentGradeFile();
            var studentGrades = repo.GetStudentGradesBySubject(studentId);
            dgvGradingSubjects.DataSource = studentGrades;
            dgvGradingSubjects.Refresh();
        }

        private void btnGradeSubject_Click(object sender, EventArgs e)
        {
            // Gets the selected row from the enrolled subjects datagridview and passes the student ID and subject code to the grading form
            if (dgvEnrolledSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = dgvEnrolledSubjects.SelectedRows[0];
            string subjectCode = selectedRow.Cells["ENRDFSTUDSUBJCDE"].Value?.ToString();
            string edpCode = selectedRow.Cells["ENRDFSTUDEDPCODE"].Value?.ToString();

            if (string.IsNullOrEmpty(subjectCode) || string.IsNullOrEmpty(edpCode))
            {
                MessageBox.Show("Invalid subject code or EDP code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open the grading form and pass the student ID and subject code
            var gradingForm = new GradingSubject(studentId, subjectCode, edpCode);
            gradingForm.ShowDialog();

            // Refresh the grading subjects DataGridView after grading
            LoadGradingSubjects();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (NoSelection()) return;

            var confirmation = MessageBox.Show("Are you sure you want to delete this enrolled subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                var repo = new RepositoryEnrollmentDetailFile();

                // Ensure ID is parsed correctly before passing it to delete function
                if (long.TryParse(dgvEnrolledSubjects.SelectedRows[0].Cells["ENRDFSTUDID"].Value?.ToString(), out long studentId))
                {
                    string subjectCode = dgvEnrolledSubjects.SelectedRows[0].Cells["ENRDFSTUDSUBJCDE"].Value?.ToString();
                    string edpCode = dgvEnrolledSubjects.SelectedRows[0].Cells["ENRDFSTUDEDPCODE"].Value?.ToString();

                    if (!string.IsNullOrEmpty(subjectCode) && !string.IsNullOrEmpty(edpCode))
                    {
                        var result = repo.DeleteEnrollmentDetail(studentId, subjectCode, edpCode);
                        if (result.Success)
                        {
                            MessageBox.Show("Enrolled subject deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadEnrolledSubjects();
                        }
                        else
                        {
                            MessageBox.Show($"Failed to delete enrolled subject: {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete enrolled subject. Invalid subject code or EDP code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to delete enrolled subject. Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool NoSelection()
        {
            if (dgvEnrolledSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void btnGradeDelete_Click(object sender, EventArgs e)
        {
            if (dgvGradingSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmation = MessageBox.Show("Are you sure you want to delete this grade?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                var repo = new RepositoryStudentGradeFile();

                // Ensure ID is parsed correctly before passing it to delete function
                if (long.TryParse(dgvGradingSubjects.SelectedRows[0].Cells["SGFSTUDID"].Value?.ToString(), out long studentId))
                {
                    string subjectCode = dgvGradingSubjects.SelectedRows[0].Cells["SGFSTUDSUBJCODE"].Value?.ToString();
                    string edpCode = dgvGradingSubjects.SelectedRows[0].Cells["SGFSTUDEDPCODE"].Value?.ToString();

                    if (!string.IsNullOrEmpty(subjectCode) && !string.IsNullOrEmpty(edpCode))
                    {
                        var result = repo.DeleteStudentGrade(studentId, subjectCode, edpCode);
                        if (result.Success)
                        {
                            MessageBox.Show("Grade deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGradingSubjects();
                        }
                        else
                        {
                            MessageBox.Show($"Failed to delete grade: {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete grade. Invalid subject code or EDP code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to delete grade. Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

