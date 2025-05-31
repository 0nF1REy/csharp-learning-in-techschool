using prjCliente.Models;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace prjCliente
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida��o: campos obrigat�rios
                if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtCelular.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos!", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Valida��o: nome
                if (!Regex.IsMatch(txtNome.Text, @"^[A-Za-z�-�' ]{2,50}$"))
                {
                    MessageBox.Show("Nome inv�lido! Use apenas letras, espa�os e ap�strofos. Tamanho entre 2 e 50 caracteres.",
                                    "Aten��o",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Valida��o: e-mail
                if (!txtEmail.Text.Contains("@") && !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("E-mail inv�lido! Est� faltando o s�mbolo '@' e o ponto '.'.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!txtEmail.Text.Contains("@"))
                {
                    MessageBox.Show("E-mail inv�lido! Est� faltando o s�mbolo '@'.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("E-mail inv�lido! Est� faltando o ponto '.'.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Valida��o: celular
                if (!Regex.IsMatch(txtCelular.Text, @"^[0-9\-]+$"))
                {
                    MessageBox.Show("Celular inv�lido! Apenas n�meros e h�fens s�o permitidos.",
                                    "Aten��o",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Instancia��o do objeto Cliente
                Cliente meuCliente = new Cliente();
                meuCliente.Cli_nome = txtNome.Text;
                meuCliente.Cli_celular = txtCelular.Text;
                meuCliente.Cli_email = txtEmail.Text;

                // Exibi��o de dados
                MessageBox.Show(
                    $"Os seguintes dados foram cadastrado com sucesso:\n" +
                    $"\n" +
                    $"===================================\n" +
                    $"Nome: {meuCliente.Cli_nome}\n" +
                    $"Celular: {meuCliente.Cli_celular}\n" +
                    $"E-mail: {meuCliente.Cli_email}\n" +
                    $"==================================="
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao tentar cadastrar o cliente.\n" +
                    $"Erro: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }
}
