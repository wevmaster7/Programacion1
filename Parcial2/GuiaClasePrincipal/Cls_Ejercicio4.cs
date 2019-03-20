using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio4
    {

        public Cls_Ejercicio4()
        {

        }


        double v, t, x=0;

        public double ejerDistancia()
        {
            Console.WriteLine("\n *******   Programa para calcular la distancia   ********\n");
            Console.WriteLine("Ingrese el valor de la velocidad: ");
            v = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tiempo: ");
            t = double.Parse(Console.ReadLine());

            x = v * t;

            Console.WriteLine("La distancia recorrida es: " + x + " m/s");

            return x;
        }

    }
}
