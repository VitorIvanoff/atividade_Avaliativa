using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa.Estrategias
{

    class EstrategiaDescontoPorCategoria : IEstrategiaDesconto
    {
        public double AplicarDesconto(Produto produto)
        {
            double precoAtual = produto.getPreco();

            if (produto.getCategoria() == "Diversos") return (precoAtual - (precoAtual * 0.10));

            return precoAtual;            
        }
    }
}
