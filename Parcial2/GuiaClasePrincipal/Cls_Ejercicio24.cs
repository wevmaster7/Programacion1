using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio24
    {

        public Cls_Ejercicio24()
        {
            
        }
        double a, b;

        public double ejerSumDif()
        {

            Console.WriteLine("Ingrese un numero");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero");
            b = double.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("La suma de los numeros es " + (a + b));
                Console.WriteLine("La diferencia  de los numeros es " + (a - b));
                Console.ReadKey();

            }
            else
                Console.WriteLine("La division de los numeros es " + (a / b));
            Console.WriteLine("La multiplicacion  de los numeros es " + (a * b));

            return a + b;

        }
    }
}
