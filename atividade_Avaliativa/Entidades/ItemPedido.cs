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
        
        public ItemPedido(Produto produto, int quantidade)
        {
            this.produto = produto;
            this.quantidade = quantidade;
        }

        public double ValorTotalItem(IEstrategiaDesconto estrategiaDesconto)
        {
            return estrategiaDesconto.AplicarDesconto(this) * quantidade;
        }

        public Produto GetProduto() {return this.produto;}
        public void SetProduto(Produto produto) {this.produto = produto;}

        public int GetQuantidade() {return this.quantidade;}
        public void SetQuantidade(int quantidade) { this.quantidade = quantidade;}
    }
}
