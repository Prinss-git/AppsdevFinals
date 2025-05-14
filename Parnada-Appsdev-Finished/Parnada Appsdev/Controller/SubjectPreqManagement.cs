using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Controller.SubjectPreqControls;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.EntryControls
{
    public partial class SubjectPreqManagement: UserControl
    {
        public SubjectPreqManagement()
        {
            InitializeComponent();
            Theme.ApplyDataGridViewTheme(dgvSubjectsPreq);
            SubjectPreqReader();
        }

        private void SubjectPreqReader()
        {
            var repo = new RepositorySubjectPreq();
            dgvSubjectsPreq.DataSource = repo.GetSubjectPreq();
            dgvSubjectsPreq.Refresh();
        }

        private void subjectPreqAdd_Click(object sender, EventArgs e)
        {
            using (SubjectPreqAdd subjectPreqAddForm = new SubjectPreqAdd())
            {
                DialogResult result = subjectPreqAddForm.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    SubjectPreqReader(); // Call your database update logic here
                }
            }
        }


        private void subjectPreqEdit_Click(object sender, EventArgs e)
        {
            if (NoSelection()) return;

            try
            {
                string subjCode = dgvSubjectsPreq.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
                string subjPreCode = dgvSubjectsPreq.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                string subjCategory = dgvSubjectsPreq.SelectedRows[0].Cells[2].Value?.ToString() ?? "";

                // Open an edit form or pass data to an edit UserControl
                using (SubjectPreqEdit subjectPreqEdit = new SubjectPreqEdit(subjCode, subjPreCode, subjCategory))
                {
                    DialogResult result = subjectPreqEdit.ShowDialog();

                    if (result == DialogResult.Cancel)
                    {
                        SubjectPreqReader(); // Call your database update logic here
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subject prerequisite data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subjectPreqDelete_Click(object sender, EventArgs e)
        {
            if (NoSelection()) return;

            var confirmation = MessageBox.Show("Are you sure you want to delete this subject prerequisite?",
                                               "Confirm Delete",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                var repo = new RepositorySubjectPreq();

                // Ensure subject codes are retrieved before passing to delete function
                string subjCode = dgvSubjectsPreq.SelectedRows[0].Cells[0].Value?.ToString();
                string subjPreCode = dgvSubjectsPreq.SelectedRows[0].Cells[1].Value?.ToString();

                if (!string.IsNullOrEmpty(subjCode) && !string.IsNullOrEmpty(subjPreCode))
                {
                    repo.DeleteSubjectPreq(subjCode, subjPreCode);
                    MessageBox.Show("Subject prerequisite deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SubjectPreqReader(); // Refresh the DataGridView after deletion
                }
                else
                {
                    MessageBox.Show("Failed to delete subject prerequisite. Invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool NoSelection()
        {
            if (dgvSubjectsPreq.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void SubjectPreqManagement_ControlRemoved(object sender, ControlEventArgs e)
        {
            SubjectPreqReader();
        }
    }
}
