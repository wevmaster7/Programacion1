using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio34
    {


        public Cls_Ejercicio34()
        {

        }

        int num;
        string opc;
        public int Numero()
        {
            Console.WriteLine("Ingrese un numero cualquiera");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Que desea saber?");
            Console.WriteLine("1.Determinar si es positivo o negativo");
            Console.WriteLine("2.Determinar si es par o impar");
            Console.WriteLine("Elija una opcion");
            opc = Console.ReadLine();

            switch(opc)
            {
                case "1":
                    if (num > 0)
                    {
                        Console.WriteLine("Es positivo");
                    }
                    else
                    {
                        Console.WriteLine("Es negativo");
                    }
                    break;

                case "2":
                    if ((num%2)==0)
                    {
                        Console.WriteLine("El numero es par");
                    }
                    else
                    {
                        Console.WriteLine("El numero es impar");
                    }
                    break;
            }

            return num;
        }   
    
    }
}
