using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
   public  class Cls_Ejercicio14
    {

        public Cls_Ejercicio14()
        {
            
        }
        double val1, val2, val3, val4, suma, prom;

        public double ejerCalculaSumaProm()
        {

            Console.WriteLine("*****    Programa que calcula suma y promedio   ***** \n");
            Console.WriteLine("Ingrese el primer valor numerico: ");
            val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor numerico: ");
            val2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor numerico: ");
            val3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto valor numerico: ");
            val4 = double.Parse(Console.ReadLine());

            suma = val1 + val2 + val3 + val4;

            prom = suma / 4;
            Console.WriteLine("EL suma de todos los valores es: " + suma);
            Console.WriteLine("El promedio de los valores es: " + prom);

            return prom;

        }
    }
}
