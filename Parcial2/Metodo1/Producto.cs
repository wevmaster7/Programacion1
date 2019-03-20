using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo1
{
    public class Producto
    {



        int n1, n2, resul;

        public int metodoProducto()
        {

            Console.WriteLine("********  Metodo que multiplica dos numeros   ******* \n");
            Console.WriteLine("Ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            
            if (n1 != 0)
            {
                Console.WriteLine("Ingrese el segundo numero: ");
                n2 = int.Parse(Console.ReadLine());

                

                if (n2 == 0 )
                {
                    Console.WriteLine("Todo numero multiplicado por 0 el resultado es 0");

                }
                else
                {

                    

                    resul = n1 * n2;
                    Console.WriteLine("EL resultado de la multiplicacion de los numeros es: {0}",resul);

                }


               

            } return num+resul;
            
         }
    }
}
