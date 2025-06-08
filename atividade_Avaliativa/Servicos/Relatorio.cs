using atividade_Avaliativa.Estrategias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa.Servicos
{
    class Relatorio
    {
        private List<Pedido> pedidos;


        public Relatorio(List<Pedido> pedidos)
        {
            this.pedidos = pedidos;
        }

        public void ListarPedidos()
        {
            foreach (Pedido pedido in this.pedidos)
            {
                pedido.DescricaoPedido();

                Console.WriteLine("\tItens do Pedido:\n");
                foreach (ItemPedido itemPedido in pedido.GetItensPedido())
                {
                    itemPedido.DescricaoItemPedido();
                }

                Console.WriteLine("\n\tValor Total do Pedido: R$" +pedido.GetValorTotal());
                Console.WriteLine("------------------------------------------\n");
            }
        }
    }
}
