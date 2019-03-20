using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio7
    {
        public Cls_Ejercicio7()
        {
            
        }

        double numero;

        public double ejerCalculaNum()
        {
            Console.WriteLine("\n *******   Calcula el 30% / 60% / 90%  de cualquier numero  ********\n");
            Console.WriteLine("ingresa un numero: ");
            numero = double.Parse(Console.ReadLine());

            Console.WriteLine("Calculo del 30%:  " + numero * 0.30);
            Console.WriteLine("Calculo del 60%:  " + numero * 0.60);
            Console.WriteLine("Calculo del 90%:  " + numero * 0.90);

            return numero;
        }
    }
}
