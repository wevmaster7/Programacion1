using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Cls_Ejercicio11
    {
         public Cls_Ejercicio11()
        {
            
        }

         public double sueldoEmpleado()
         {

             Console.WriteLine("\n *****    Sueldo de Empleado con descuento de salud y pension    *****");
             int dias;
             double suel, sueldo, S_total, afp, isss, desc;

             Console.WriteLine("Ingrese cual es sueldo diario: ");
             suel = double.Parse(Console.ReadLine());
             Console.WriteLine("ingrese la cantidad de dias trabajados: ");
             dias = int.Parse(Console.ReadLine());

             sueldo = suel * dias;
             afp = sueldo * 0.10;
             isss = sueldo * 0.15;
             desc = afp + isss;
             S_total = sueldo - desc;

             Console.WriteLine("El sueldo total es: " + S_total);
             Console.WriteLine("el descuento de pension es: " + afp);
             Console.WriteLine("El descuento de salud es: " + isss);

             return S_total;
         }
            

        /*
        public void mostrarSueldo()
        {

            Console.WriteLine("El sueldo total es: "+S_total);
            Console.WriteLine("el descuento de pension es: " + afp);
            Console.WriteLine("El descuento de salud es: "+isss);
         */ 
        
    }
}
