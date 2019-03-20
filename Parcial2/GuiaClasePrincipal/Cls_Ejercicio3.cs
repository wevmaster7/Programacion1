using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio3
    {
        public Cls_Ejercicio3()
        {

        }

        int num1, num2, div;

        public int ejerDivide()
        {
            Console.WriteLine("\n *******   Division de dos numeros   ********\n");
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            div = num1 / num2;

            Console.WriteLine("El resultado de la suma es: " + div);

            return div;

        }
    }
}
