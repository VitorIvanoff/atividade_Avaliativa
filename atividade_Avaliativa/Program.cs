using atividade_Avaliativa.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa
{
    class Program
    {
        static void Main(string[] args)
        {            
            Cliente cliente = new Cliente(1, "Gabriel", "exemple@exemple.com", "123.456.789-10");
            

            try
            {
                Produto lapis = new Produto(1, "Lápis", 1.30, "Diversos");
                Produto caneta = new Produto(2, "Caneta", 2.50, "Diversos");
                Produto borracha = new Produto(3, "borracha", 3.00, "Diversos");

                ItemPedido itemLapis = new ItemPedido(lapis, 10);
                ItemPedido itemCaneta = new ItemPedido(caneta, 2);
                ItemPedido itemBorracha = new ItemPedido(borracha, 4);

                Pedido pedido = new Pedido(1, cliente, new List<ItemPedido> { itemLapis, itemCaneta }, DateTime.Now);

                Relatorio relatorio = new Relatorio(new List<Pedido> { pedido });

                relatorio.ListarPedidos();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
                        
        }
    }

}
