using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa.Estrategias
{
    class EstrategiaDescontoPorQuantidade : IEstrategiaDesconto
    {
        public double AplicarDesconto(ItemPedido itemPedido)
        {
            double precoAtual = itemPedido.getProduto().getPreco();

            if (itemPedido.getQuantidade() > 10) return (precoAtual - (precoAtual * 0.15));

            return precoAtual;
        }
    }
}
