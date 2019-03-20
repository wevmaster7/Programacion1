using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio19
    {
        public Cls_Ejercicio19()
        {
            
        }

        double a;

        public double ejerAplicaR()
        {
            Console.WriteLine("A que grado asiste en numeros");
            a = double.Parse(Console.ReadLine());
            if (a < 6)
            {
                Console.WriteLine("Si aplica para refrigerio");
                Console.ReadKey();
            }
            else
                Console.WriteLine("No aplica para refrigerio");

            return a;
        }
    }
}
