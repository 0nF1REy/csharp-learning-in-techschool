using Microsoft.VisualBasic;
using prjAula0905.Views;

namespace prjAula0905
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario login = new frmFuncionario();
            login.ShowDialog();
        }
    }
}
