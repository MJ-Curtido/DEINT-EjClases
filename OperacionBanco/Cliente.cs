using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cliente
    {
        public String Dni { get; set; }
        public String Nombre { get; set; }
        public Double CantidadAhorrada { get; set; }
    
        public void Ingresar(Double dinero)
        {
            this.CantidadAhorrada = this.CantidadAhorrada + dinero;
        }

        public void Extraer(Double dinero)
        {
            if ((this.CantidadAhorrada - dinero) >= 0)
            {
                this.CantidadAhorrada = this.CantidadAhorrada - dinero;
            }
            else
            {
                Console.WriteLine("La cantidad que se quiere extraer es mayor a la cantidad ahorrada actual");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("La cantidad ahorrada actual es: " + this.CantidadAhorrada);
        }
    }
}
