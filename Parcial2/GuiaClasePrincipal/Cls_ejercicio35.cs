using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_ejercicio35
    {

        public Cls_ejercicio35()
        {

        }

        double n1, n2, n3, prom;
        int nacimiento, actual, edad;
        string opc;
        public double Promedio()
        {
            Console.WriteLine("¿Que desea saber?");
            Console.WriteLine("1.Pasa o no pasa la materia");
            Console.WriteLine("2.Es mayor o menor de edad");
            Console.WriteLine("Elija una opcion");
            opc = Console.ReadLine();

            switch (opc)
            {
                case "1":
                    Console.WriteLine("INGRESE LA NOTA DE LA PRIMERA EVALUACION");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE LA NOTA DE LA SEGUNDA EVALUACION");
                    n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE LA NOTA DE LA TERCERA EVALUACION");
                    n3 = double.Parse(Console.ReadLine());

                    prom = (n1 + n2 + n3) / 3;

                    if (prom > 3)
                    {
                        Console.WriteLine("Pasa la materia");
                    }
                    else
                    {
                        Console.WriteLine("N0 pasa la materia");
                    }
                    break;

                case "2":
                    Console.WriteLine("Ingrese su año de nacimiento (ej. 1980)");
                    nacimiento = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el año actual (ej.2019)");
                    actual = int.Parse(Console.ReadLine());

                    edad = actual - nacimiento;

                    Console.WriteLine("Su edad es: " + edad);
                    break;
            } return prom;
        }
    }
}
