using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa
{
    public class Cliente
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

        public int GetId() { return this.id; }
        public void SetId(int id) { this.id = id; }

        public string GetNome() { return this.nome; }
        public void SetNome(string nome) { this.nome = nome; }

        public string GetEmail() { return this.email; }
        public void SetEmail(string email) { this.email = email; }

        public string GetCpf() { return this.cpf; }
        public void SetCpf (string cpf) { this.cpf = cpf; }
    }
}
