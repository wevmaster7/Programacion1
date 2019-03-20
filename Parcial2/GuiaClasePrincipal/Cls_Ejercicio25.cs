using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio25
    {
        public Cls_Ejercicio25()
        {
            
        }

        double N1, N2, N3, Prom;

        public double ejerPromocionado()
        {

            Console.WriteLine("Ingrese su primera nota");
            N1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segunda nota");
            N2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tercera nota");
            N3 = double.Parse(Console.ReadLine());

            Prom = N1 + N2 + N3 / 3;

            if (Prom > 7)
            {
                Console.WriteLine("Promocionado");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Reprobado");

            return Prom;
        }
    }
}
