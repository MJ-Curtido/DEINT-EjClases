using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloIsosceles
{
    internal class Triangulo
    {
        public Double LongitudLadoIgual { get; set; }
        public Double LongitudLadoDif { get; set; }
        public Double Altura { get; set; }

        public Triangulo(double LongitudLadoIgual, double LongitudLadoDif)
        {
            this.LongitudLadoIgual = LongitudLadoIgual;
            this.LongitudLadoDif = LongitudLadoDif;
            this.Altura = Math.Sqrt(Math.Pow(LongitudLadoIgual, 2) - (Math.Pow(LongitudLadoDif, 2) / 4));
        }

        public void calcularPerimetro()
        {
            Console.WriteLine((this.LongitudLadoIgual * 2) + this.LongitudLadoDif);
        }

        public void calcularArea()
        {
            Console.WriteLine(this.LongitudLadoDif * this.Altura / 2);
        }
    }
}
