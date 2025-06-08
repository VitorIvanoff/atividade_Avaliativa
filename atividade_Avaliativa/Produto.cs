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
        private string id { get; set; }
        private string nome { get; set; }
        private double preco { get; set; }
        private string categoria { get; set; }

        public Produto(string id, string nome, double preco, string categoria)
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
    }

}

