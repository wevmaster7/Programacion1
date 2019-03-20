using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio10
    {

         public Cls_Ejercicio10()
        {
            
        }

        int n, i;

        public double ejerCompra()
        {
            double P_uni = 0, suma_P = 0;
            Console.WriteLine("\n *******   Valor total a pagar de un cliente por compra de productos  ********\n");

            Console.WriteLine("Ingresa la cantidad de productos a comprar: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {

                Console.WriteLine("Ingrese el precio del producto: " + i);
                P_uni = double.Parse(Console.ReadLine());
                suma_P = suma_P + P_uni;
            }


            Console.WriteLine("El total a pagar con iva es: " + suma_P * 1.13);

            return suma_P;
        }
    }
}
