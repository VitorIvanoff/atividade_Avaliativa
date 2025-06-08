using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa
{
    class Pedido
    {
        private int id;
        private Cliente cliente;
        private List<Produto> produtos;
        private DateTime data;
        private double valorTotal;


        public Pedido(int id, Cliente cliente, List<Produto> produtos, DateTime data)
        {
            this.id = id;
            this.cliente = cliente;
            this.produtos = produtos;
            this.data = data;

            CalcularValorTotal();
        }

        private void CalcularValorTotal()
        {        
            foreach (Produto produto in this.produtos)
            {
                this.valorTotal += produto.getPreco();
            }
        }

        public int getId () { return this.id; }
        public void setId(int id) { this.id = id; }

        public Cliente getCliente() { return this.cliente; }
        public void setCliente(Cliente cliente) { this.cliente = cliente; }

        public List<Produto> getProdutos() { return this.produtos; }
        public void setProdutos(List<Produto> produtos)
        {
            this.produtos = produtos;
            CalcularValorTotal();
        }

        public DateTime getData() { return this.data; }
        public void setData(DateTime data) { this.data = data; }

        public double getValorTotal() { return this.valorTotal; }
    }
}
