using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio28
    {

        public Cls_Ejercicio28()
        {
            
        }

        double a;

        public double ejerParImpar(){

        Console.WriteLine("Ingrese el precio del producto");
            a = double.Parse(Console.ReadLine());

            if(a%2==0)
            {
                Console.WriteLine("Es par");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Es impar");

            return a;
        }
    }
}
