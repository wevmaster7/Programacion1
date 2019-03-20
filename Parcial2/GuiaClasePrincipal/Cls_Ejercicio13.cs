using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio13
    {

        public Cls_Ejercicio13()
        {
            
        }


        double num1, num2, num3, num4, num5, suma, producto,resul1, resul2;

        public double ejerCalcularNum()
        {

            Console.WriteLine("\n *****   Programa con 5 numeros a calcular   ***** \n ");
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero: ");
            num4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto numero: ");
            num5 = double.Parse(Console.ReadLine());

            suma = num1 + num2;
            producto = num3 * num4;
            resul1 = suma * producto;
            resul2 = producto / suma;

            Console.WriteLine("La suma de los primeros dos numeros es: " + suma);
            Console.WriteLine("El producto de los numeros es: " + producto);
            Console.WriteLine("La multiplicacion de los resultados es: " + resul1);
            Console.WriteLine("La division de los resultados es: " + resul2);

            return suma + producto + resul1 + resul2; 

        }
    }
}
