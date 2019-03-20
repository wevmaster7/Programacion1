using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio31
    {

        public Cls_Ejercicio31()
        {

        }


        double altura, peso, edad;

        public double pesoEdadAlt()
        {
            Console.WriteLine("Ingresa tu edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu peso");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu altura");
            altura = double.Parse(Console.ReadLine());

            if (edad > 18 && peso > 80 && altura > 1.80)
            {
                Console.WriteLine("Aceptado");
                Console.ReadKey();
            }
            else
                Console.WriteLine("No Aceptado");
            return altura + peso + edad;
        }
    }
}
