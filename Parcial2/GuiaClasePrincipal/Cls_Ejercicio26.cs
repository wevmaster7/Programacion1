using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio26
    {

        public Cls_Ejercicio26()
        {
            
        }

        double a;

        public double ejerNumeroDig()
        {

            Console.WriteLine("Ingrese un numero desde el 1 hasta el 99");
            a = double.Parse(Console.ReadLine());


            if (a < 10)
            {
                Console.WriteLine("El numero tiene un digito");
                Console.ReadKey();

            }
            else
                Console.WriteLine("El numero tiene dos digitos");
            Console.ReadKey();

            return a;
        }
    }
}
