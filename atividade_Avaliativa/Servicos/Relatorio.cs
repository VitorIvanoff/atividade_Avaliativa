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
                Console.WriteLine(pedido.GetId() + " | " + pedido.GetData()+ "\n");
                Console.WriteLine("\tID: "+ pedido.GetCliente().GetId() +  "\n\tCliente: " + pedido.GetCliente().GetNome() + "\n\tCPF: " + pedido.GetCliente().GetCpf() + "\n\tE-mail: " + pedido.GetCliente().GetEmail() + "\n");
                Console.WriteLine("\tItens do Pedido: ");

                foreach (ItemPedido itemPedido in pedido.GetItensPedido())
                {
                    Console.WriteLine("\t\tID: " + itemPedido.GetProduto().GetId());
                    Console.WriteLine("\t\tProduto: " + itemPedido.GetProduto().GetNome());
                    Console.WriteLine("\t\tCategoria: " + itemPedido.GetProduto().GetCategoria());
                    Console.WriteLine("\t\tQuantidade: " + itemPedido.GetQuantidade());
                    Console.WriteLine("\t\tPreço: R$" + itemPedido.GetProduto().GetPreco());
                    Console.WriteLine("\t\tSub Total: R$" + itemPedido.ValorTotalItem(new EstrategiaDescontoPorQuantidade()));
                    Console.WriteLine("\t----------------------------------");
                }

                Console.WriteLine("\n\tValor Total do Pedido: R$" +pedido.GetValorTotal()); 
            }
        }
    }
}
