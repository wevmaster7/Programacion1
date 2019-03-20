using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio39
    {

        public Cls_Ejercicio39()
        {

        }
        public int FOR4()
        {
            int f, edad, cont;
            cont = 0;
            for (f = 1; f <= 20; f = f + 1)
            {
                Console.WriteLine("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());


                if (edad >= 18)
                {

                    cont = cont + 1;
                }
            }

            Console.WriteLine("La cantidad de alumnos mayores de edad es: " + cont);


            return f +  cont;

        }
    }
}
