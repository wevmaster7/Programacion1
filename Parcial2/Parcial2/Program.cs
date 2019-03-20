using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodo1;
using Metodo2;
using Metodo3;
using Metodo4;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {

            Producto obj1 = new Producto();
            Divide obj2 = new Divide();
            Nombres obj3 = new Nombres();
            Notas obj4 = new Notas();
            


            int valor=0;

            Console.WriteLine("Ingrese uno de los metodos a ejecutar");
            Console.WriteLine("1. Metodo que Multiplica dos numeros");
            Console.WriteLine("2. Metodo que Divide dos numero");
            Console.WriteLine("3. Metodo que pide 5 nombres con For ");
            Console.WriteLine("4. Metodo que pide 5 notas con do-While");
            valor = int.Parse(Console.ReadLine());

            switch (valor){

            case 1: Console.WriteLine(obj1.metodoProducto());
            break;

                case 2: Console.WriteLine(obj2.metodoDivide());
            break;

                case 3: Console.WriteLine(obj3.MetodoFor());
            break;
                case 4: Console.WriteLine(obj4.notasAlumno());
            break;

                default:
                    Console.WriteLine("Ha ingresado un numero no valido");
                    break;

                    
            
            }

            Console.ReadKey();
            
        } 
    }
}
