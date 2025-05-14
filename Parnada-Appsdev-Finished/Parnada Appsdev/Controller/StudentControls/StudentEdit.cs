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
using System.Text.RegularExpressions;

namespace Parnada_Appsdev.Controller.EntryControls
{
    public partial class StudentEdit : UserControl
    {
        private long studentId;
        private string firstName;
        private string middleName;
        private string lastName;
        private string course;
        private int yearLevel;
        private string remarks;
        private string status;

        public StudentEdit(long studentId, string firstName, string middleName, string lastName, string course, int yearLevel, string remarks, string status)
        {
            InitializeComponent();

            tbStudentID.Text = studentId.ToString();
            tbFirstName.Text = firstName;
            tbMiddleName.Text = middleName;
            tbLastName.Text = lastName;
            cboCourse.SelectedIndex = cboCourse.Items.IndexOf(course);
            cboYear.Value = yearLevel;
            cboRemarks.SelectedIndex = cboRemarks.Items.IndexOf(remarks);
            cboStatus.SelectedIndex = cboStatus.Items.IndexOf(status);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateControls(this))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(tbStudentID.Text, out long studentId))
            {
                MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Name Fields
            if (!IsValidName(tbFirstName.Text) || !IsValidName(tbMiddleName.Text) || !IsValidName(tbLastName.Text))
            {
                MessageBox.Show("Invalid name! Please enter only letters, spaces, apostrophes, or hyphens.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var repo = new RepositoryStudentFile();

            StudentFile student = new StudentFile
            {
                STFSTUDID = studentId,
                STFSTUDFNAME = tbFirstName.Text,
                STFSTUDMNAME = tbMiddleName.Text,
                STFSTUDLNAME = tbLastName.Text,
                STFSTUDCOURSE = cboCourse.Text,
                STFSTUDYEAR = (int)cboYear.Value, // Numeric year level
                STFSTUDREMARKS = cboRemarks.Text,
                STFSTUDSTATUS = cboStatus.Text
            };

            int result = repo.UpdateStudent(student);

            if (result > 0)
            {
                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Validator.ClearControls(this);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("Failed to update student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                e.Handled = true; // Block input
            }
        }

        // Validate before saving
        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z\s'-]+$"); // Allows letters, spaces, apostrophes, and hyphens
        }
    }
}
