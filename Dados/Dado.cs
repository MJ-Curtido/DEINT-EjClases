using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Dado
    {
        public int Valor { get; set; }

        public Dado()
        {

        }

        public void Tirar()
        {
            Random rnd = new Random();

            this.Valor =  rnd.Next(1, 7);
        }

        public void Imprimir()
        {
            Console.WriteLine(this.Valor);
        }
    }
}
