using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa
{
    public class Produto
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
            if (string.IsNullOrWhiteSpace(nome)) { throw new Exception("O nome do produto não pode ser vazio"); }
            if (preco <= 0) { throw new Exception("O preço do produto não pode ser menor ou igual a zero"); }
            if (string.IsNullOrWhiteSpace(categoria)) { throw new Exception("A categoria do produto não pode ser vazia"); }

            return true;
        }

        public int GetId () { return this.id; }
        public void SetId(int id) { this.id = id; }

        public string GetNome () { return this.nome; }
        public void SetNome(string nome) { this.nome = nome; }

        public double GetPreco () { return this.preco; }
        public void SetPreco (double preco) { this.preco = preco; }

        public string GetCategoria () { return this.categoria; }
        public void SetCategoria(string categoria) { this.categoria = categoria; }
    }

}

