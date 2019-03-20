using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio17
    {
        public Cls_Ejercicio17()
        {

        }

        
        double a;
        public double mostrarPosNeg() 
        {
            Console.WriteLine("Ingrese un numero");
            a = double.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("El numero es positivo");
                Console.ReadKey();
            }
            else
                Console.WriteLine("El numero es negativo");

            return a;
            
        }
    }
}
