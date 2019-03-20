using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
   public  class Cls_Ejercicio15
    {
       public Cls_Ejercicio15()
        {
            
        }


        double precio, n;

        public double ejerArticulos()

        {
            Console.WriteLine("******  Calcula la cantidad de producto y abono  ******* ");
            Console.WriteLine("Ingresa el precio del articulo: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de articulos: ");
            n = double.Parse(Console.ReadLine());

            Console.WriteLine("La cantidad a abonar es: {0:C} ", precio * n);
            return precio;
        }
    }
}
