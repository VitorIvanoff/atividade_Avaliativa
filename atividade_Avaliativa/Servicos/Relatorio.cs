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
                Console.WriteLine(pedido.getId() + " | " + pedido.getData()+ "\n");
                Console.WriteLine("\tID: "+ pedido.getCliente().getId() +  "\n\tCliente: " + pedido.getCliente().getNome() + "\n\tCPF: " + pedido.getCliente().getCpf() + "\n\tE-mail: " + pedido.getCliente().getEmail() + "\n");
                Console.WriteLine("\tItens do Pedido: ");

                foreach (ItemPedido itemPedido in pedido.getItensPedido())
                {
                    Console.WriteLine("\t\tID: " + itemPedido.getProduto().getId());
                    Console.WriteLine("\t\tProduto: " + itemPedido.getProduto().getNome());
                    Console.WriteLine("\t\tCategoria: " + itemPedido.getProduto().getCategoria());
                    Console.WriteLine("\t\tQuantidade: " + itemPedido.getQuantidade());
                    Console.WriteLine("\t\tPreço: R$" + itemPedido.getProduto().getPreco());
                    Console.WriteLine("\t\tSub Total: R$" + itemPedido.ValorTotalItemComDesconto(new EstrategiaDescontoPorQuantidade()));
                    Console.WriteLine("\t----------------------------------");
                }
                Console.WriteLine("\n\tValor Total do Pedido: R$" +pedido.getValorTotal()); 

            }
        }
    }
}
