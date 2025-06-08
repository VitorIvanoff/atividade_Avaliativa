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

        public double ValorTotalItem()
        {
            return produto.getPreco() * quantidade;
        }

        public double ValorTotalItemComDesconto(IEstrategiaDesconto estrategiaDesconto)
        {
            return estrategiaDesconto.AplicarDesconto(this.produto) * quantidade;
        }

        public Produto getProduto() {return this.produto;}
        public void setProduto(Produto produto) {this.produto = produto;}

        public int getQuantidade() {return this.quantidade;}
        public void setQuantidade(int quantidade) { this.quantidade = quantidade;}
    }
}
