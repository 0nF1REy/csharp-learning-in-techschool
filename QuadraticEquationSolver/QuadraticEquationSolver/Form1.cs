namespace QuadraticEquationSolver
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

        private void btnCalcularX1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = ObterValor(txtA.Text, "A");
                double b = ObterValor(txtB.Text, "B");
                double c = ObterValor(txtC.Text, "C");

                double delta = CalcularDelta(a, b, c);

                if (delta < 0)
                {
                    txtResposta.Text = "Não existem raízes reais.";
                    return;
                }

                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                txtResposta.Text = $"X1 = {x1:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularX2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = ObterValor(txtA.Text, "A");
                double b = ObterValor(txtB.Text, "B");
                double c = ObterValor(txtC.Text, "C");

                double delta = CalcularDelta(a, b, c);

                if (delta < 0)
                {
                    txtResposta.Text = "Não existem raízes reais.";
                    return;
                }

                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                txtResposta.Text = $"X2 = {x2:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para obter e validar um valor numérico a partir de um texto.
        private double ObterValor(string texto, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
                throw new ArgumentException($"O valor de {nomeCampo} não pode ser vazio.");

            if (!double.TryParse(texto, out double valor))
                throw new ArgumentException($"O valor de {nomeCampo} deve ser numérico.");

            return valor;
        }

        // Método para calcular o delta (discriminante) de uma equação de 2º grau.
        private double CalcularDelta(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }
    }
}
