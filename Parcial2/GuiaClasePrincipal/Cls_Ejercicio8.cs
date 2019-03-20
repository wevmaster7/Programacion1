using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio8
    {
         public Cls_Ejercicio8()
        {
            
        }

        double lado;
        public double ejerCalculaArea()
        {

            Console.WriteLine("\n *******  calcular el área de un cuadrado   ********\n");
            Console.WriteLine("Ingrese el valor de un lado del cuadrado: ");
            lado = double.Parse(Console.ReadLine());

            Console.WriteLine("el area del cuadrado es: " + lado * lado);
            return lado;
        }
    }
}
