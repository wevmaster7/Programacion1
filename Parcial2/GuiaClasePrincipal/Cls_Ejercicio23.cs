using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio23
    {
         public Cls_Ejercicio23()
        {
            
        }


        double a, b, c, d;

        public double ejerProDescuento()
        {

            Console.WriteLine("Ingrese el precio del producto");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad del producto");
            b = double.Parse(Console.ReadLine());

            c = a * b;

            if (c > 100000)
            {
                c = c * 0.8;
                Console.WriteLine("Se ha aplicado un descuento del 20% el precio a pagar es " + c);
                Console.ReadKey();
            }
            else
                Console.WriteLine("No aplica descuento el precio a pagar es " + c);


            return c;

        }
    }
}
