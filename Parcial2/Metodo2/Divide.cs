using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo2
{
    public class Divide
    {
        int n1, n2, num, resul;

        public int metodoDivide()
        {

            Console.WriteLine("********  Metodo que divide dos numeros   ******* \n");
            Console.WriteLine("Ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 != 0)
            {
                Console.WriteLine("Ingrese el segundo numero: ");
                n2 = int.Parse(Console.ReadLine());



                if (n2 == 0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero");

                }
                else
                {



                    resul = n1 / n2;
                    Console.WriteLine("EL resultado de la division de los numeros es: " + resul);

                }




            } return num + resul;
        }
    }
}
