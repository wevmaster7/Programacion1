using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio2
    {

        public Cls_Ejercicio2()
        {

        }
        int num1, num2, num3, producto;

        public int ejerProduc()
        {
            Console.WriteLine("\n *******   Producto de 3 numeros   ********\n");
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            producto = num1 * num2 * num3;

            Console.WriteLine("El resultado del producto es: " + producto);

            return producto;
        }
    }
}
