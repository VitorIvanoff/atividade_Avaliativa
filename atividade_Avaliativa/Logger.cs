using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace atividade_Avaliativa
{
    public class Logger
    {
        private string referencia;

        public Logger(string referencia) 
        { 
            this.referencia = referencia;
        }

        public void Info(string message, string[] args)
        {
            Console.WriteLine($"[{referencia} - {DateTime.Now}]" + message, args);
        }
    }
}
