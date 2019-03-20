using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio5
    {
        public Cls_Ejercicio5()
        {

        }

          int naci, actual, edad;
          public int ejerEdad()
          {

              Console.WriteLine("\n *******  calcular la edad de una persona conociendo el año actual   ********\n");
              Console.WriteLine("Ingresa la el año en que naciste: ");
              naci = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingresa la fecha actual: ");
              actual = int.Parse(Console.ReadLine());


              edad = actual - naci;

           
              Console.WriteLine("Tu edad es: " + edad + " años");

              return edad;
          }
    }
}
