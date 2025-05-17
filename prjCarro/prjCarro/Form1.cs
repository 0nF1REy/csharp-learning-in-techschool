using prjCarro.Views;
using System.Windows.Forms;

namespace prjCarro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            this.FormClosing += static (s, e) =>
            {
                if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            };
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {


            // Instancia o formulário de cadastro
            frmCadastro cadastro = new frmCadastro();

            // Abre o formulário como modal, bloqueando o formulário pai até ser fechado.
            cadastro.ShowDialog();

            // Abre o formulário como não modal, permitindo interação simultânea.
            // Requer IsMdiContainer desabilitado para evitar comportamento MDI.
            // cadastro.Show();
        }
    }
}
