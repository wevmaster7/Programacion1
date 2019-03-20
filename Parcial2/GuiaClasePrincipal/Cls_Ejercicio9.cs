using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio9
    {
         public Cls_Ejercicio9()
        {
            
        }

         double num1, num2, num3, num4, num5, prom;

         public double ejerCalculaPro()
         {

             Console.WriteLine("\n *******   Calcula el promedio de 5 numeros  ********\n");
             Console.WriteLine("Ingresa el primer valor: ");
             num1 = double.Parse(Console.ReadLine());
             Console.WriteLine("Ingresa el segundo valor: ");
             num2 = double.Parse(Console.ReadLine());
             Console.WriteLine("Ingresa el tercer valor: ");
             num3 = double.Parse(Console.ReadLine());
             Console.WriteLine("Ingresa el cuarto valor: ");
             num4 = double.Parse(Console.ReadLine());
             Console.WriteLine("Ingresa el quinta valor: ");
             num5 = double.Parse(Console.ReadLine());

             prom = (num1 + num2 + num3 + num4 + num5) / 5;

             Console.WriteLine("El promedio obtenido es: " + prom);

             return prom;
         }

    }
}
