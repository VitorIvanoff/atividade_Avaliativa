using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa.Estrategias
{

    class EstrategiaDescontoPorCategoria : IEstrategiaDesconto
    {
        public double AplicarDesconto(ItemPedido itemPedido)
        {
            double precoAtual = itemPedido.GetProduto().GetPreco();

            if (itemPedido.GetProduto().GetCategoria() == "Diversos") return (precoAtual - (precoAtual * 0.10));

            return precoAtual;            
        }
    }
}
