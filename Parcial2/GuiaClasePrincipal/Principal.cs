using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaClasePrincipal
{
    class Principal
    {
        static void Main(string[] args)
        {

            Cls_Ejercicio1 obj = new Cls_Ejercicio1();
            Cls_Ejercicio2 obj2 = new Cls_Ejercicio2();
            Cls_Ejercicio3 obj3 = new Cls_Ejercicio3();
            Cls_Ejercicio4 obj4 = new Cls_Ejercicio4();
            Cls_Ejercicio5 obj5 = new Cls_Ejercicio5();
            Cls_Ejercicio6 obj6 = new Cls_Ejercicio6();
            Cls_Ejercicio7 obj7 = new Cls_Ejercicio7();
            Cls_Ejercicio8 obj8 = new Cls_Ejercicio8();
            Cls_Ejercicio9 obj9 = new Cls_Ejercicio9();
            Cls_Ejercicio10 obj10 = new Cls_Ejercicio10();
            Cls_Ejercicio11 obj11 = new Cls_Ejercicio11();
            Cls_Ejercicio12 obj12 = new Cls_Ejercicio12();
            Cls_Ejercicio13 obj13 = new Cls_Ejercicio13();
            Cls_Ejercicio14 obj14 = new Cls_Ejercicio14();
            Cls_Ejercicio15 obj15 = new Cls_Ejercicio15();
            Cls_Ejercicio16 obj16 = new Cls_Ejercicio16();
            Cls_Ejercicio17 obj17 = new Cls_Ejercicio17();
            Cls_Ejercicio18 obj18 = new Cls_Ejercicio18();
            Cls_Ejercicio19 obj19 = new Cls_Ejercicio19();            
            Cls_Ejercicio20 obj20 = new Cls_Ejercicio20();         
            Cls_Ejercicio21 obj21 = new Cls_Ejercicio21();
            Cls_Ejercicio22 obj22 = new Cls_Ejercicio22();
            Cls_Ejercicio23 obj23 = new Cls_Ejercicio23();        
            Cls_Ejercicio24 obj24 = new Cls_Ejercicio24();              
            Cls_Ejercicio25 obj25 = new Cls_Ejercicio25();        
            Cls_Ejercicio26 obj26 = new Cls_Ejercicio26();           
            Cls_Ejercicio27 obj27 = new Cls_Ejercicio27();            
            Cls_Ejercicio28 obj28 = new Cls_Ejercicio28();

            
            Cls_Ejercicio29 obj29 = new Cls_Ejercicio29();
            Cls_Ejercicio30 obj30 = new Cls_Ejercicio30();

            
            Cls_Ejercicio31 obj31 = new Cls_Ejercicio31();
            Cls_Ejercicio32 obj32 = new Cls_Ejercicio32();
            Cls_Ejercicio33 obj33 = new Cls_Ejercicio33();
            Cls_Ejercicio34 obj34 = new Cls_Ejercicio34();
            Cls_ejercicio35 obj35 = new Cls_ejercicio35();
            Cls_Ejercicio36 obj36 = new Cls_Ejercicio36();
            Cls_Ejercicio37 obj37 = new Cls_Ejercicio37();
            Cls_Ejercicio38 obj38 = new Cls_Ejercicio38();
            Cls_Ejercicio39 obj39 = new Cls_Ejercicio39();
            Cls_Ejercicio40 obj40 = new Cls_Ejercicio40();

            int ejercicios;

            Console.WriteLine("**************************************************************************** \n");
            Console.WriteLine("INGRESE UN NUMERO ENTRE 1 Y 60 PARA MOSTRAR EL EJERCICIO QUE DESEA EJECUTAR:\n " );
            Console.Write("                 Cada numero contiene un ejercicio \n con diferentes funciones de acuerdo a los parametros solicitados \n \n INGRESE EL NUMERO: ");
            ejercicios = int.Parse(Console.ReadLine());

            switch (ejercicios)

                    
            {
                case 1: Console.WriteLine(obj.ejerSuma());
                    break;


                case 2: Console.WriteLine(obj2.ejerProduc());
                    break;

                case 3: Console.WriteLine(obj3.ejerDivide());
                    break;

                case 4: Console.WriteLine(obj4.ejerDistancia());
                    break;

                case 5: Console.WriteLine(obj5.ejerEdad());
                    break;

                case 6: Console.WriteLine(obj6.ejerPorcentaje());
                    break;

                case 7: Console.WriteLine(obj7.ejerCalculaNum());
                    break;

                case 8: Console.WriteLine(obj8.ejerCalculaArea());
                    break;

                case 9: Console.WriteLine(obj9.ejerCalculaPro());
                    break;

                case 10: Console.WriteLine(obj10.ejerCompra());
                    break;

                case 11: Console.WriteLine(obj11.sueldoEmpleado());
                    break;

                case 12: Console.WriteLine(obj12.ejerCalculaPeri());
                    break;

                case 13: Console.WriteLine(obj13.ejerCalcularNum());
                    break;

                case 14: Console.WriteLine(obj14.ejerCalculaSumaProm());
                    break;

                case 15: Console.WriteLine(obj15.ejerArticulos());
                    break;

                case 16: Console.WriteLine(obj16.ejerMayorEdad());
                    break;

                case 17: Console.WriteLine(obj17.mostrarPosNeg());
                    break;

                case 18: Console.WriteLine(obj18.ejerNumeroM());
                    break;


                case 19: Console.WriteLine(obj19.ejerAplicaR());
                    break;


                case 20: Console.WriteLine(obj20.ejerNumeroMay());
                    break;



                case 21: Console.WriteLine(obj21.ejerSumaRes());
                    break;



                case 22: Console.WriteLine(obj22.ejerAproRepro());
                   break;


                case 23: Console.WriteLine(obj23.ejerProDescuento());
                  break;




                case 24: Console.WriteLine(obj24.ejerSumDif());
                   break;



                case 25: Console.WriteLine(obj25.ejerPromocionado());
                  break;



                case 26: Console.WriteLine(obj26.ejerNumeroDig());
                    break;



                case 27: Console.WriteLine(obj27.ejerDescuentoPagar());
                     break;

                

                case 28: Console.WriteLine(obj28.ejerParImpar());
                    break;



                case 29: Console.WriteLine(obj29.ejerSemanaFC());
                    break;

                case 30: Console.WriteLine(obj30.PrecioCompra());
                    break;



                case 31: Console.WriteLine(obj31.pesoEdadAlt());
                break;


                case 32: Console.WriteLine(obj32.vocales());
                break;

                case 33: Console.WriteLine(obj33.Formula());
                break;

                case 34: Console.WriteLine(obj34.Numero());
                break;

                case 35: Console.WriteLine(obj35.Promedio());
                break;

                case 36: Console.WriteLine(obj36.bucleFOR());
                break;

                case 37: Console.WriteLine(obj37.FOR2());
                break;

                case 38: Console.WriteLine(obj38.FOR3());
                break;

                case 39: Console.WriteLine(obj39.FOR4());
                break;

                case 40: Console.WriteLine(obj40.FOR5());
                break;








                default:
                    Console.WriteLine("HA ELEGIDO UN NUMERO NO VALIDO, EL PROGRAMA SE CERRARA ");
                    break;

            }
            Console.ReadKey();
        }
    }
}
