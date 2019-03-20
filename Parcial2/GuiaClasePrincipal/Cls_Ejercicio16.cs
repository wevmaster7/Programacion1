using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio16
    {


        public Cls_Ejercicio16()
        {

        }

        int a, b, c;
        public  int ejerMayorEdad(){

            Console.WriteLine("\n *******  calcular si una persona es mayor o menor de edad   ********\n");
        Console.WriteLine("Ingresa tu año de nacimiento");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu año actual");
            c = int.Parse(Console.ReadLine());
            b = a - c;
            b = Math.Abs(b);

            if (b>18){
            
             Console.WriteLine("eres mayor de edad");
            Console.ReadKey();
            }
            else
                Console.WriteLine("eres menor de edad");

            return b;
        }
    }
}
