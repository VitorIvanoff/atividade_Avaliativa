using atividade_Avaliativa.Estrategias;
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
            Cliente clienteGabriel = new Cliente(1, "Gabriel", "gabriel@exemple.com", "123.456.789-10");
            Cliente clienteMiguel = new Cliente(2, "Miguel", "miguel@exemple.com", "903.456.789-10");
            Cliente clienteIgor = new Cliente(3, "Igor", "igor@exemple.com", "973.456.789-10");

            try
            {
                Produto lapis = new Produto(1, "Lápis", 1.30, "Diversos");
                Produto caneta = new Produto(2, "Caneta", 2.50, "Diversos");
                Produto borracha = new Produto(3, "borracha", 3.00, "Diversos");

                ItemPedido itemLapis = new ItemPedido(lapis, 12, new EstrategiaDescontoPorCategoria());
                ItemPedido itemCaneta = new ItemPedido(caneta, 2, new EstrategiaDescontoPorQuantidade());

                Pedido pedido = new Pedido(1, clienteGabriel, new List<ItemPedido> { itemLapis, itemCaneta }, DateTime.Now);

                Relatorio relatorio = new Relatorio(new List<Pedido> { pedido });

                relatorio.ListarPedidos();
            }
            catch(Exception ex) 
            {
                Logger logger = new Logger("Program");
                logger.Log(ex.Message);
            }
                        
        }
    }

}
