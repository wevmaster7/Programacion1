using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio22
    {
        public Cls_Ejercicio22()
        {
            
        }

         string Cod, Nombre, Mnom;
        double N1, N2, N3, Prom;

        public double ejerAproRepro(){

        Console.WriteLine("Ingrese su nombre");
            Nombre = Console.ReadLine();
             Console.WriteLine("Ingrese su codigo");
            Cod = Console.ReadLine();
             Console.WriteLine("Ingrese el nombre de la materia");
             Mnom = Console.ReadLine();


             Console.WriteLine("Ingrese su primera nota");
            N1 = double.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese su segunda nota");
            N2 = double.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese su tercera nota");
            N3 = double.Parse(Console.ReadLine());

            Prom = N1+N2+N3/3;
            if (Prom>4)
            {
                Console.WriteLine("Aprobado");
                Console.WriteLine("El nombre es " + Nombre);
                Console.WriteLine("El nombre de la materia es " + Mnom);
                Console.WriteLine("El Codigo de estudiante es " + Cod);
                Console.ReadKey();

            }
            else
                Console.WriteLine("Reprobado");
                Console.WriteLine("El nombre es " + Nombre);
                Console.WriteLine("El nombre de la materia es " + Mnom);
                Console.WriteLine("El Codigo de estudiante es " + Cod);

            return Prom;

        }
    }
}
