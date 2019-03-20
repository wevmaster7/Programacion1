using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio6
    {
        public Cls_Ejercicio6()
        {
            
        }

        int numero;

        public int ejerPorcentaje()
        {
            Console.WriteLine("\n *******   Calcula el 20% de cualquier numero  ********\n");
            Console.WriteLine("ingresa un numero: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: " + numero * 0.20);
            return numero;
        } 
    }
}
