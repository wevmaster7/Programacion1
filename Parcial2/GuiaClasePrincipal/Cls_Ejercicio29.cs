using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio29
    {

        public Cls_Ejercicio29()
        {

        }


        int Tlunes, Tmartes, Tmiercoles, Tjueves, Tviernes, Tsabado, Tdomingo, Prom;


        public string ejerSemanaFC()
        {

            Console.WriteLine("Ingrese la temperatura del Lunes");
            Tlunes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura del Martes");
            Tmartes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura del Miercoles");
            Tmiercoles = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura del Juves");
            Tjueves = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura del Viernes");
            Tviernes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura del Sabado");
            Tsabado = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura del Domingo");
            Tdomingo = int.Parse(Console.ReadLine());

            Prom = (Tlunes + Tmartes + Tmiercoles + Tjueves + Tviernes + Tsabado + Tdomingo) / 7;
            if (Prom > 35)
            {
                Console.WriteLine("Que semana tan calurosa");
                Console.ReadKey();

            }
            else if (Prom > 15)
            {
                Console.WriteLine("Que clima tan delicioso");
                Console.ReadKey();

            }
            else if (Prom < 15)
            {
                Console.WriteLine("Que Semana tan fria");



            } return "";
        }
    }
}
