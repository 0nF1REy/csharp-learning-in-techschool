using System;
using System.Drawing;
using System.Windows.Forms;

namespace dark_mode
{
    public partial class frmPrincipal : Form
    {
        bool DarkMode = false;

        public frmPrincipal()
        {
            InitializeComponent();

            DarkMode = Properties.Settings.Default.DarkMode;
            ApplyTheme(this, DarkMode);
            this.Text = DarkMode ? "Modo Escuro" : "Modo Claro";

            this.FormClosing += static (s, e) =>
            {
                if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            };
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            DarkMode = !DarkMode;
            ApplyTheme(this, DarkMode);
            this.Text = DarkMode ? "Modo Escuro" : "Modo Claro";

            Properties.Settings.Default.DarkMode = DarkMode;
            Properties.Settings.Default.Save();
        }

        private void ApplyTheme(Control ctrl, bool darkMode)
        {
            if (darkMode)
            {
                ctrl.BackColor = Color.FromArgb(30, 30, 30);
                ctrl.ForeColor = Color.White;
            }
            else
            {
                ctrl.BackColor = SystemColors.Control;
                ctrl.ForeColor = SystemColors.ControlText;
            }

            foreach (Control child in ctrl.Controls)
            {
                ApplyTheme(child, darkMode);
            }
        }
    }
}
