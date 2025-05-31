using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCliente.Models
{
    internal class Cliente
    {
        private int cli_id;
        private string cli_nome;
        private string cli_celular;
        private string cli_email;

        // Getters e Setters
        public int Cli_id { get => cli_id; set => cli_id = value; }
        public string Cli_nome { get => cli_nome; set => cli_nome = value; }
        public string Cli_email { get => cli_email; set => cli_email = value; }
        public string Cli_celular { get => cli_celular; set => cli_celular = value; }

        // Métodos comportamentais
        public void Cadastrar()
        {
            MessageBox.Show("Cadastro efetuado com sucesso!");
        }

        public void Editar()
        {
            MessageBox.Show("Edição efetuado com sucesso!");
        }

        public void Excluir()
        {
            MessageBox.Show("Exclusão efetuado com sucesso!");
        }

        public void Pesquisar()
        {
            MessageBox.Show("Pesquisa efetuado com sucesso!");
        }
    }
}
