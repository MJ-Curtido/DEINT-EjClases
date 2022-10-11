using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal static class Juego
    {
        public static Dado[] ListaDados { get; set; } = new Dado[3] { new Dado(), new Dado(), new Dado() };

        public static void Jugar()
        {
            StringBuilder cadena = new StringBuilder();
            Boolean win = true;

            cadena.Append("Las 3 tiradas han sido: ");

            foreach (var dado in ListaDados)
            {
                dado.Tirar();
                cadena.Append(dado.Valor + " ");

                if (dado.Valor != ListaDados[0].Valor && win)
                {
                    win = false;
                }
            }

            if (win)
            {
                Console.WriteLine(cadena + "\nUsted ha ganado! :)");
            }
            else
            {
                Console.WriteLine(cadena + "\nUsted ha perdido :(");
            }
        }
    }
}
