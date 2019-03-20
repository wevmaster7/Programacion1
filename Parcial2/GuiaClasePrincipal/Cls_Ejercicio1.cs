using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    public class Cls_Ejercicio1
    {

        public Cls_Ejercicio1()
        {

        }

        int num1, num2, suma;
            public int ejerSuma(){
                
            Console.WriteLine("\n *******   suma de 2 numeros   ********\n" );
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;

            Console.WriteLine("El resultado de la suma es: " +suma);
            return suma;
        }
    }
}
