using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Models;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.EntryControls
{
    public partial class StudentAdd: UserControl
    {
        public StudentAdd()
        {
            InitializeComponent();
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
                STFSTUDID = GenerateStudentID(), // Generate unique ID
                STFSTUDFNAME = tbFirstName.Text,
                STFSTUDMNAME = tbMiddleName.Text,
                STFSTUDLNAME = tbLastName.Text,
                STFSTUDCOURSE = cboCourse.Text,
                STFSTUDYEAR = int.Parse(cboYear.Text),
                STFSTUDREMARKS = cboRemarks.Text,
                STFSTUDSTATUS = cboStatus.Text
            };

            var result = repo.CreateStudent(student);
            if (result.Success)
            {
                MessageBox.Show("Student saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Validator.ClearControls(this);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show($"Failed to save student. {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Helper methods
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
            return Regex.IsMatch(name, @"^[a-zA-Z\s'-]+$");
        }

        // Generate unique Student ID
        private long GenerateStudentID()
        {
            return (long)(Math.Abs(Guid.NewGuid().GetHashCode()) % 90000000) + 10000000;
        }


    }
}
