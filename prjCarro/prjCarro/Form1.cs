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


            // Instancia o formul�rio de cadastro
            frmCadastro cadastro = new frmCadastro();

            // Abre o formul�rio como modal, bloqueando o formul�rio pai at� ser fechado.
            cadastro.ShowDialog();

            // Abre o formul�rio como n�o modal, permitindo intera��o simult�nea.
            // Requer IsMdiContainer desabilitado para evitar comportamento MDI.
            // cadastro.Show();
        }
    }
}
