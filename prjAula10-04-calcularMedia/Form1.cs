namespace prjAula10_04_calcularMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textNota1.Text) ||
                    string.IsNullOrWhiteSpace(textNota2.Text) ||
                    string.IsNullOrWhiteSpace(textNota3.Text))
                {
                    MessageBox.Show("Insira algo valido");
                    return;
                }

                double nota1 = double.Parse(textNota1.Text);
                double nota2 = double.Parse(textNota2.Text);
                double nota3 = double.Parse(textNota3.Text);

                if (nota1 > 10 || nota2 > 10 || nota3 > 10)
                {
                    MessageBox.Show("Insira valores iguais ou menores que 10");
                }
                else if (nota1 <= 0 || nota2 <= 0 || nota3 <= 0)
                {
                    MessageBox.Show("Insira valores maiores que zero");
                }


                double media = (nota1 + nota2 + nota3) / 3;
                textMedia.Text = media.ToString("F2");

                if (media >= 7)
                {
                    textMedia.Text = media.ToString();
                    textStatus.Text = "Aprovado";

                }
                else
                {
                    textMedia.Text = media.ToString();
                    textStatus.Text = "Reprovado";
                }

            }
            catch
            {
                MessageBox.Show("Erro, Insira valores validos");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
