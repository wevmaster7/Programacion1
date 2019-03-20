using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio30

    {

        public Cls_Ejercicio30()
        {

        }

        double Pcompra, des, Tpagar;
        public double PrecioCompra()
        {

            Console.WriteLine("Ingrese el precio de compra");
            Pcompra = double.Parse(Console.ReadLine());

            if (Pcompra > 10000 && Pcompra < 20000)
            {
                Console.WriteLine("Aplica el 10% de descuento, el total a pagar es " + Pcompra * 0.90);
                Console.ReadKey();
            }
            else if (Pcompra > 20001 && Pcompra < 50000)
            {
                Console.WriteLine("Aplica el 30% de descuento, el total a pagar es " + Pcompra * 0.70);
                Console.ReadKey();
            }
            else if (Pcompra > 50000)
            {
                Console.WriteLine("Aplica el 50% de descuento, el total a pagar es " + Pcompra * 0.50);
                Console.ReadKey();
            }
            else
                Console.WriteLine("No aplica descuento, el total a pagar es " + Pcompra);
            return Pcompra;

        }
    }
}
