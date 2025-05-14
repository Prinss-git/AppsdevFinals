using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Parnada_Appsdev.Controller;
using Parnada_Appsdev.Controller.EntryControls;

namespace Parnada_Appsdev
{
    public partial class Main : MaterialForm
    {

        public Main()
        {
            InitializeComponent();
            Theme.ApplyTheme();
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tcMain.SelectedTab;

            if (selectedTab == tabPageStudent)
            {
                ShowUserControl(new StudentManagement(), tabPageStudent);
            }
            else if (selectedTab == tabPageLogout)
            {
                this.Close();
            }
            else if (selectedTab == tabPageSubjectManagement)
            {
                ShowUserControl(new SubjectManagement(), tabPageSubjectManagement);
            }
            else if (selectedTab == tabPageSubjectPreq)
            {
                ShowUserControl(new SubjectPreqManagement(), tabPageSubjectPreq);
            }
            else if (selectedTab == tabPageSubjectSchedManagement)
            {
                ShowUserControl(new SubjectSchedManagement(), tabPageSubjectSchedManagement);
            }
            else if (selectedTab == tabPageEnrollment)
            {
                ShowUserControl(new EnrollmentManagement(), tabPageEnrollment);
            }

        }

        public void ShowUserControl(UserControl control, TabPage tabPage)
        {
            // Check if the control is already present
            if (!tabPage.Controls.Contains(control))
            {
                control.Dock = DockStyle.Fill;  // Make it fill the tab page
                tabPage.Controls.Add(control);  // Add UserControl to the TabPage
            }

            // Bring the control to the front
            control.BringToFront();
        }

    }
}
