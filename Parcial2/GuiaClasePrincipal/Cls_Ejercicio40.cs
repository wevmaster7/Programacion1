using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio40
    {
        public Cls_Ejercicio40()
        {

        }

        public int FOR5()
        {
            int f, contF, contH;
            string genero;
            contF = 0;
            contH = 0;
            for (f = 1; f <= 25; f = f + 1)
            {
                Console.WriteLine("Ingrese su genero (F o M): ");
                genero = Console.ReadLine();


                if (genero == "F")
                {

                    contF = contF + 1;
                }
                else
                {
                    contH = contH + 1;
                }
            }

            Console.WriteLine("La cantidad de mujeres es: " + contF);
            Console.WriteLine("La cantidad de hombres es: " + contH);
            return f + contF + contH;
        }
    }
}
