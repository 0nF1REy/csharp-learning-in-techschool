using prjCarro.Models;

namespace prjCarro.Views
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
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

        private void btnVisualizarDados_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um objeto Carro e popula com os dados dos campos de texto
                Carro meuCarro = new Carro();
                meuCarro.Marca = txtMarca.Text;
                meuCarro.Modelo = txtModelo.Text;
                meuCarro.Ano = Convert.ToInt32(txtAno.Text);
                meuCarro.Placa = txtPlaca.Text;
                meuCarro.QuantidadePortas = Convert.ToInt32(txtQntPortas.Text);
                meuCarro.QuantidadeAssentos = Convert.ToInt32(txtCadAssentos.Text);
                meuCarro.TipoCombustivel = txtTipoCombustivel.Text;

                // Exibe os dados do carro em uma caixa de mensagem formatada
                MessageBox.Show(
                    $"Marca: {meuCarro.Marca}\n" +
                    $"Modelo: {meuCarro.Modelo}\n" +
                    $"Ano: {meuCarro.Ano}\n" +
                    $"Placa: {meuCarro.Placa}\n" +
                    $"Quantidade de Portas: {meuCarro.QuantidadePortas}\n" +
                    $"Quantidade de Assentos: {meuCarro.QuantidadeAssentos}\n" +
                    $"Tipo de Combustível: {meuCarro.TipoCombustivel}"
                );
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Insira valores numéricos válidos para Ano, Quantidade de Portas e Quantidade de Assentos.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
