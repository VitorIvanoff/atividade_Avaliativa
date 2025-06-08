using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa
{
    class Cliente
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;


        public Cliente(int id, string nome, string email, string cpf)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
        }


        public int getId() { return id; }
        public void setId(int id) { this.id = id; }

        public string getNome() { return nome; }
        public void setNome(string nome) { this.nome = nome; }

        public string getEmail() { return email; }
        public void setEmail(string email) { this.email = email; }

        public string getCpf() { return cpf; }
        public void setCpf (string cpf) { this.cpf = cpf; }


    }
}
