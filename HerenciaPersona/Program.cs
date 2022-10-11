// See https://aka.ms/new-console-template for more information

using HerenciaPersona;

Empleado empleado1 = new Empleado("Miguelito", 2, 7.7);
Empleado empleado2 = new Empleado("Manolin", 20, 1700.7);
Empleado empleado3 = new Empleado("Martukas", 5, 17.7);

Console.WriteLine($"{empleado1.ToString()}\n{empleado2.ToString()}\n{empleado3.ToString()}");