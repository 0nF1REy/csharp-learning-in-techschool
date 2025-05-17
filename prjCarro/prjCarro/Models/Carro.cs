namespace prjCarro.Models
{
    internal class Carro
    {
        private string marca;
        private string modelo;
        private int ano;
        private string placa;
        private int quantidadePortas;
        private int quantidadeAssentos;
        private string tipoCombustivel;
        private bool ligado = false;

        // Getters e Setters
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Placa { get => placa; set => placa = value; }
        public int QuantidadePortas { get => quantidadePortas; set => quantidadePortas = value; }
        public int QuantidadeAssentos { get => quantidadeAssentos; set => quantidadeAssentos = value; }
        public string TipoCombustivel { get => tipoCombustivel; set => tipoCombustivel = value; }

        // Métodos comportamentais
        public void LigarCarro()
        {
            if (!ligado)
            {
                ligado = true;
                MessageBox.Show("O carro foi ligado.");
            }
            else
            {
                MessageBox.Show("O carro já está ligado.");
            }
        }

        public void DesligarCarro()
        {
            if (ligado)
            {
                ligado = false;
                MessageBox.Show("O carro foi desligado.");
            }
            else
            {
                MessageBox.Show("O carro já está desligado.");
            }
        }

        public void AcelerarCarro()
        {
            if (ligado)
            {
                MessageBox.Show("Vruuum! O carro está acelerando!");
            }
            else
            {
                MessageBox.Show("Você precisa ligar o carro antes de acelerar.");
            }
        }

        public void FrearCarro()
        {
            MessageBox.Show("O carro está freando.");
        }

        public void TrocarMarchaCarro()
        {
            if (ligado)
            {
                MessageBox.Show("Marcha trocada com sucesso.");
            }
            else
            {
                MessageBox.Show("Não é possível trocar de marcha com o carro desligado.");
            }
        }

        public void AbastecerCarro()
        {
            MessageBox.Show("O carro foi abastecido.");
        }
    }
}
