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
            Produto produto;
            try
            {
                 produto = new Produto(1, "Lápis", 1.30, "Diversos");

                produto.setNome("caneta"); 
               
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }

}
