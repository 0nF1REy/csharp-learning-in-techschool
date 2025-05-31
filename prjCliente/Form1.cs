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
                // Validação: campos obrigatórios
                if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtCelular.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validação: nome
                if (!Regex.IsMatch(txtNome.Text, @"^[A-Za-zÀ-ÿ' ]{2,50}$"))
                {
                    MessageBox.Show("Nome inválido! Use apenas letras, espaços e apóstrofos. Tamanho entre 2 e 50 caracteres.",
                                    "Atenção",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Validação: e-mail
                if (!txtEmail.Text.Contains("@") && !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("E-mail inválido! Está faltando o símbolo '@' e o ponto '.'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!txtEmail.Text.Contains("@"))
                {
                    MessageBox.Show("E-mail inválido! Está faltando o símbolo '@'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("E-mail inválido! Está faltando o ponto '.'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validação: celular
                if (!Regex.IsMatch(txtCelular.Text, @"^[0-9\-]+$"))
                {
                    MessageBox.Show("Celular inválido! Apenas números e hífens são permitidos.",
                                    "Atenção",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Instanciação do objeto Cliente
                Cliente meuCliente = new Cliente();
                meuCliente.Cli_nome = txtNome.Text;
                meuCliente.Cli_celular = txtCelular.Text;
                meuCliente.Cli_email = txtEmail.Text;

                // Exibição de dados
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
