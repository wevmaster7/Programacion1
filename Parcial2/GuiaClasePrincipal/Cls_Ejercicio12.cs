using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio12
    {
        public Cls_Ejercicio12()
        {
            
        }

        public double ejerCalculaPeri()
        {
            double lado, peri;
            Console.WriteLine("\n *****    Calcular el perimetro de un cuadrado por su lado   ****");
            Console.WriteLine("Ingrese el lador del cuadrado: ");
            lado = double.Parse(Console.ReadLine());

            peri = lado * 4;

            Console.WriteLine("El perimetro del cuadrado es: " + peri);
            return peri;
                 
        }
    }
}
