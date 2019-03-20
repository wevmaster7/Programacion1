using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio20
    {
            public Cls_Ejercicio20()
        {
            
        }

         double a, b, c;

         public double ejerNumeroMay()
         {

             Console.WriteLine("Ingrese un numero ");
             a = double.Parse(Console.ReadLine());
             b = a / 2;
             if (b > 100)
             {
                 Console.WriteLine("el numero es mayor a 100");
                 Console.ReadKey();
             }
             else
                 Console.WriteLine("el numero es menor a 100");
             Console.ReadKey();

             return b;
         }
    }
}
