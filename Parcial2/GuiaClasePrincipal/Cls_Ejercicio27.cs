using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio27
    {

        public Cls_Ejercicio27()
        {
            
        }

        double a, b, c;

        public double ejerDescuentoPagar()
        {
            Console.WriteLine("Ingrese el precio del producto");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad del producto");
            b = double.Parse(Console.ReadLine());

            c = a * b;

            if (c < 20000)
            {
                c = c * 0.80;
                Console.WriteLine("Se ha aplicado el 20% de descuento el total a pagar es " + c);
                Console.ReadKey();

            }
            else
                c = c * 0.65;
            Console.WriteLine("Se ha aplicado el 35 % de descuento el total a pagar es " + c);

            return c;

        }
    }
}
