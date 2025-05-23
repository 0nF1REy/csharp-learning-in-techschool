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
                if (!double.TryParse(textNota1.Text, out double nota1) ||
                    !double.TryParse(textNota2.Text, out double nota2) ||
                    !double.TryParse(textNota3.Text, out double nota3))
                {
                    MessageBox.Show("Insira valores numéricos válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                double nota1 = double.Parse(textNota1.Text);
                double nota2 = double.Parse(textNota2.Text);
                double nota3 = double.Parse(textNota3.Text);

                if (nota1 > 10 || nota2 > 10 || nota3 > 10)
                {
                    MessageBox.Show("Insira valores iguais ou menores que 10", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Interrompe a execução
                }
                else if (nota1 < 0 || nota2 < 0 || nota3 < 0)
                {
                    MessageBox.Show("Insira valores maiores ou iguais a zero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Interrompe a execução
                }


                double media = (nota1 + nota2 + nota3) / 3;
                textMedia.Text = media.ToString("F2");

                if (media >= 7)
                {
                    textStatus.Text = "Aprovado";
                }
                else
                {
                    textStatus.Text = "Reprovado";
                }
            }
            catch
            {
                MessageBox.Show("Erro, insira valores válidos");
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
