using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio21
    {

        public Cls_Ejercicio21()
        {
            
        }

        double a, b, c;

        public double ejerSumaRes(){

        Console.WriteLine("Ingrese un numero");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero");
            b = double.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a - b;
                Console.WriteLine("La resta de los numeros es" + c);
                Console.ReadKey();
            }
            else
                c = a + b;
                Console.WriteLine("La suma de los numeros es "+ c);
            return a+b+c;
        }

    }
}
