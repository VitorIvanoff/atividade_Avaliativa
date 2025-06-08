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
                this.valorTotal += itemPedido.ValorTotalItem();
            }
        }

        public void DescricaoPedido()
        {
            Cliente cliente = this.cliente;

            Console.WriteLine($"Pedido: #{this.GetId()} | Realizado em: {this.GetData()}\n");
            Console.WriteLine($"\tID: {cliente.GetId()}\n\tCliente: {cliente.GetNome()}\n\tCPF: {cliente.GetCpf()}\n\tE-mail: {cliente.GetEmail()}\n");
        }

        public int GetId() { return this.id; }
        public void SetId(int id) { this.id = id; }

        public Cliente GetCliente() { return this.cliente; }
        public void SetCliente(Cliente cliente) { this.cliente = cliente; }

        public List<ItemPedido> GetItensPedido() { return this.itensPedido; }
        public void SetItensPedido(List<ItemPedido> itensPedido)
        {
            this.itensPedido = itensPedido;
            CalcularValorTotal();
        }

        public DateTime GetData() { return this.data; }
        public void SetData(DateTime data) { this.data = data; }

        public double GetValorTotal() { return this.valorTotal; }
    }
}
