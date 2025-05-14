using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using Microsoft.TeamFoundation.Common;
using Parnada_Appsdev.Models;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.GradingControl
{
    public partial class GradingSubject : Form
    {
        private long studentId;
        private string subjectCode;
        private string edpCode;


        public GradingSubject(long studentId, string subjectCode, string edpCode)
        {
            InitializeComponent();
            tbSubjectCode.Text = subjectCode;
            this.studentId = studentId;
            this.subjectCode = subjectCode;
            this.edpCode = edpCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbRemarks.Text == "Invalid Grade")
            {
                MessageBox.Show("Cannot save an invalid grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbRemarks.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please update the grade first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(tbGrade.Text, out double grade))
            {
                var repo = new RepositoryStudentGradeFile();

                // Check for duplicate grade
                var existingGrades = repo.GetStudentGradesPrimary(studentId, subjectCode, edpCode);
                if (existingGrades.Any())
                {
                    MessageBox.Show("A grade for this subject already exists.", "Duplicate Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var studentGrade = new StudentGradeFile
                {
                    SGFSTUDID = studentId,
                    SGFSTUDSUBJCODE = subjectCode,
                    SGFSTUDSUBJGRADE = grade,
                    SGFSTUDEDPCODE = edpCode,
                    SGFSTUDREMARKS = tbRemarks.Text
                };

                var result = repo.AddStudentGrade(studentGrade);

                if (result.Success)
                {
                    MessageBox.Show("Grade saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Failed to save grade: {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid grade.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and a single decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbGrade_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbGrade.Text, out double grade))
            {
                if (grade > 3.0 && grade <= 5.0)
                {
                    tbRemarks.Text = "Failed";
                }
                else if (grade > 5.0)
                {
                    tbRemarks.Text = "Invalid Grade";
                }
                else
                {
                    tbRemarks.Text = "Passed";
                }
            }
        }

    }
}
