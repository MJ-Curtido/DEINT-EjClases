using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal static class Banco
    {
        public static Cliente[] ListaClientes { get; set; } = new Cliente[3] { new Cliente(), new Cliente(), new Cliente()};

        public static void Operar(String Dni, int metodo, Double dinero)    //Si se le pasa por parámetro 1, realiza un ingreso, si es 2 realiza una extracción
        {
            Boolean esta = false;
            int cliente = 0;

            for (int i = 0; i < ListaClientes.Length && !esta; i++)
            {
                if (ListaClientes[i].Dni.Equals(Dni))
                {
                    esta = true;
                }
            }

            if (esta)
            {
                if (metodo == 1)
                {
                    ListaClientes[cliente].Ingresar(dinero);
                }
                else if (metodo == 2)
                {
                    ListaClientes[cliente].Extraer(dinero);
                }
                else
                {
                    Console.WriteLine("Introduzca un método correcto");
                }
            }
            else
            {
                Console.WriteLine("La persona con el dni introducido no está guardada");
            }
        }

        public static void CantidadTotal()
        {
            Double cantidad = 0;

            for (int i = 0; i < ListaClientes.Length; i++)
            {
                cantidad += ListaClientes[i].CantidadAhorrada;
            }

            Console.WriteLine("La cantidad de dinero depositado en el banco es " + cantidad);
        }
    }
}