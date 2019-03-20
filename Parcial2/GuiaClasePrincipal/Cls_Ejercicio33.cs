using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio33
    {
        public Cls_Ejercicio33()
        {

        }

        double V, X, T;
        string opc;
        public double Formula()
        {
            Console.WriteLine("Escoja la operacion que desea");
            Console.WriteLine("1.Velocidad");
            Console.WriteLine("2.Tiempo");
            Console.WriteLine("2.Distancia");
            Console.WriteLine("Escoja el numero de la operacion");
            opc = Console.ReadLine();

            switch (opc)
            {
                case "1":
                    Console.WriteLine("Introduzca el tiempo");
                    T = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introducir la distancia");
                    X = double.Parse(Console.ReadLine());

                    V = (X / T);

                    Console.WriteLine("La velocidad es: " + V);
                    break;

                case "2":
                    Console.WriteLine("Introduzca el velocidad");
                    V = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca la distancia");
                    X = double.Parse(Console.ReadLine());

                    T = (X / V);

                    Console.WriteLine("El tiempo es: " + T);
                    break;

                case "3":
                    Console.WriteLine("Introduzca el velocidad");
                    V = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduzca el tiempo");
                    T = double.Parse(Console.ReadLine());

                    X = (V * T);

                    Console.WriteLine("La distancia es: " + X);
                    break;

                default: Console.WriteLine("Opcion no valida");
                    break;


            } return V + T + X;

        }
    }
}
