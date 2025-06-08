using atividade_Avaliativa.Estrategias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa
{
    public class ItemPedido
    {
        private Produto produto;
        private int quantidade;
        private IEstrategiaDesconto estrategiaDesconto;
        
        public ItemPedido(Produto produto, int quantidade, IEstrategiaDesconto estrategiaDesconto)
        {
            this.produto = produto;
            this.quantidade = quantidade;
            this.estrategiaDesconto = estrategiaDesconto;
        }

        public double ValorTotalItem()
        {
            return this.estrategiaDesconto.AplicarDesconto(this) * quantidade;
        }

        public void DescricaoItemPedido()
        {
            Produto produto = this.produto;

            Console.WriteLine("\tID: " + produto.GetId());
            Console.WriteLine("\tProduto: " + produto.GetNome());
            Console.WriteLine("\tCategoria: " + produto.GetCategoria());
            Console.WriteLine("\tQuantidade: " + this.GetQuantidade());
            Console.WriteLine("\tPreço: R$" + produto.GetPreco());
            Console.WriteLine("\tSub Total: R$" + this.ValorTotalItem());
            Console.WriteLine("\t----------------------------------");
        }

        public Produto GetProduto() {return this.produto;}
        public void SetProduto(Produto produto) {this.produto = produto;}

        public int GetQuantidade() {return this.quantidade;}
        public void SetQuantidade(int quantidade) { this.quantidade = quantidade;}
    }
}
