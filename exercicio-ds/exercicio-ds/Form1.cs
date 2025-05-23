namespace exercicio_ds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ha1 = double.Parse(textHA1.Text);
            double ha2 = double.Parse(textHA2.Text);
            double ha3 = double.Parse(textHA3.Text);


            double calHA1 = ha1 * 0.3;
            double calHA2 = ha2 * 0.3;
            double calHA3 = ha3 * 0.3;

            double cal1 = calHA1 + ha1;
            double cal2 = calHA2 + ha2;
            double cal3 = calHA3 + ha3;

            double calSM1 = cal1 * 4.5;
            double calSM2 = cal2 * 4.5;
            double calSM3 = cal3 * 4.5;

            double horaAulaTotal = ha1 + ha2 + ha3;


            textHoraAtividade1.Text = calHA1.ToString();
            textHoraAtividade2.Text = calHA2.ToString();
            textHoraAtividade3.Text = calHA3.ToString();

            textHora301.Text = cal1.ToString();
            textHora302.Text = cal2.ToString();
            textHora303.Text = cal3.ToString();

            textSubMensal1.Text = calSM1.ToString();
            textSubMensal2.Text = calSM2.ToString();
            textSubMensal3.Text = calSM3.ToString();

            textSemanal.Text = horaAulaTotal.ToString();



        }
    }
}
