using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa.Estrategias
{

    class EstrategiaDescontoPorCategoria : IEstrategiaDesconto
    {
        public double AplicarDesconto(List<ItemPedido> itensPedido)
        {
            foreach (ItemPedido itemPedido in itensPedido)
            {
                double precoAtual = itemPedido.getProduto().getPreco();

                if (itemPedido.getProduto().getCategoria() == "Diversos") return (precoAtual * 0.10);

                return precoAtual;
            }
            return 0;
        }
    }
}
