using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa.Estrategias
{
    public interface IEstrategiaDesconto
    {
        double AplicarDesconto(Produto produto);
    }
}
