using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Parnada_Appsdev
{

    public static class Theme
    {
        private static readonly MaterialSkinManager _themeManager = MaterialSkinManager.Instance;

        public static void ApplyTheme()
        {
            // Teal Theme
            _themeManager.ColorScheme = new ColorScheme(Primary.Teal900, Primary.Teal800, Primary.Teal700, Accent.Cyan700, TextShade.WHITE);
        }

        // Teal Theme
        public static void ApplyDataGridViewTheme(DataGridView dataGridView)
        {
            dataGridView.BackgroundColor = Color.FromArgb(0, 51, 51);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(0, 66, 66);
            dataGridView.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 61, 61);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 77, 64);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.GridColor = Color.FromArgb(38, 166, 154);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 172, 193);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
        }

    }
}
