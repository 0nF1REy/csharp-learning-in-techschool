using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCRUD.Models
{
    internal class Contato
    {
        private int con_id;
        private string con_nome;
        private string con_telefone;
        private string con_email;

        // Getters e Setters
        public int Con_id { get => con_id; set => con_id = value; }
        public string Con_nome { get => con_nome; set => con_nome = value; }
        public string Con_telefone { get => con_telefone; set => con_telefone = value; }
        public string Con_email { get => con_email; set => con_email = value; }

        // Métodos comportamentais
        public void Inserir()
        {
            MessageBox.Show("Inserido com sucesso!");
        }

        public void Atualizar()
        {
            MessageBox.Show("Atualizado com sucesso!");
        }

        public void Excluir()
        {
            MessageBox.Show("Exclusão efetuado com sucesso!");
        }
    }
}
