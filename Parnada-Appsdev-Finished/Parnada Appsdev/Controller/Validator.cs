using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parnada_Appsdev.Controller
{
    public static class Validator
    {
        public static bool ValidateControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is MaterialSkin.Controls.MaterialTextBox2 textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }
                else if (control is MaterialSkin.Controls.MaterialComboBox comboBox)
                {
                    if (comboBox.SelectedItem == null || string.IsNullOrWhiteSpace(comboBox.Text))
                    {
                        return false;
                    }
                }

                // Recursively check inside containers (like panels, group boxes)
                if (control.HasChildren)
                {
                    if (!ValidateControls(control))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void ClearControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is MaterialSkin.Controls.MaterialTextBox2 textBox)
                {
                    textBox.Clear();
                }
                else if (control is MaterialSkin.Controls.MaterialComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                // Recursively clear inside containers (like panels, group boxes)
                if (control.HasChildren)
                {
                    ClearControls(control);
                }
                if (control is Guna.UI2.WinForms.Guna2NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = numericUpDown.Minimum;
                }
            }
        }

    }
}
