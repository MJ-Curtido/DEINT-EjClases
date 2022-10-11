using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPersona
{
    internal class Empleado : Persona
    {
        public Double Sueldo { get; set; }

        public Empleado(String nombre, int edad, Double sueldo) : base(nombre, edad)
        {
            Sueldo = sueldo;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, sueldo: {Sueldo}";
        }
    }
}
