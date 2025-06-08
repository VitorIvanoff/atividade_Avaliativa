using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa
{
    class Produto
    {
        private int id;
        private string nome;
        private double preco;
        private string categoria;

        public Produto(int id, string nome, double preco, string categoria)
        {
            Validate(nome, preco, categoria);

            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.categoria = categoria;

        }

        private bool Validate(string nome, double preco, string categoria)
        {
            if (string.IsNullOrWhiteSpace(nome)) { throw new Exception("Nome não pode ser vazio"); }
            if (preco <= 0) { throw new Exception("O produto precisa de um preço"); }
            if (string.IsNullOrWhiteSpace(categoria)) { throw new Exception("Categoria não pode ser vazia"); }

            return true;
        }

        public int getId () { return this.id; }
        public void setId(int id) { this.id = id; }

        public string getNome () { return this.nome; }
        public void setNome(string nome) { this.nome = nome; }

        public double getPreco () { return this.preco; }
        public void setPreco (double preco) { this.preco = preco; }

        public string getCategoria () { return this.categoria; }
        public void setCategoria(string categoria) { this.categoria = categoria; }
    }

}

