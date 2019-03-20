using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio32
    {

         public Cls_Ejercicio32()
        {

        }


        string opc;
        public string vocales()
        {
            Console.WriteLine("Ingrese una letra: ");
            opc = Console.ReadLine();

            switch (opc)
            {
                case "a": Console.WriteLine("Es una vocal");
                    break;

                case "e": Console.WriteLine("Es una vocal");
                    break;

                case "i": Console.WriteLine("Es una vocal");
                    break;

                case "o": Console.WriteLine("Es una vocal");
                    break;

                case "u": Console.WriteLine("Es una vocal");
                    break;

                default: Console.Write("No es vocal");
                    break;


            }
            return "";
        }
    }
}
