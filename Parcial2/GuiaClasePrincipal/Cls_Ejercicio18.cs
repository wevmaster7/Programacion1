using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio18
    {
        public Cls_Ejercicio18()
        {

        }

         double a, b, c;

        public double ejerNumeroM(){

        Console.WriteLine("Ingrese un numero");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero");
            b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("El primer numero es mayor");
                Console.ReadKey();
            }
            else
                Console.WriteLine("El segundo numero es mayor");

            return a+b;

        }
    }
}
