using atividade_Avaliativa.Estrategias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa
{
    public class Pedido
    {
        private int id;
        private Cliente cliente;
        private List<ItemPedido> itensPedido;
        private DateTime data;
        private double valorTotal;


        public Pedido(int id, Cliente cliente, List<ItemPedido> itensPedido, DateTime data)
        {
            this.id = id;
            this.cliente = cliente;
            this.itensPedido = itensPedido;
            this.data = data;

            CalcularValorTotal();
        }

        private void CalcularValorTotal()
        {        

            foreach (ItemPedido itemPedido in this.itensPedido)
            {
                this.valorTotal += itemPedido.ValorTotalItemComDesconto(new EstrategiaDescontoPorCategoria());
            }
        }

        public int getId () { return this.id; }
        public void setId(int id) { this.id = id; }

        public Cliente getCliente() { return this.cliente; }
        public void setCliente(Cliente cliente) { this.cliente = cliente; }

        public List<ItemPedido> getItensPedido() { return this.itensPedido; }
        public void setItensPedido(List<ItemPedido> itensPedido)
        {
            this.itensPedido = itensPedido;
            CalcularValorTotal();
        }

        public DateTime getData() { return this.data; }
        public void setData(DateTime data) { this.data = data; }

        public double getValorTotal() { return this.valorTotal; }
    }
}
