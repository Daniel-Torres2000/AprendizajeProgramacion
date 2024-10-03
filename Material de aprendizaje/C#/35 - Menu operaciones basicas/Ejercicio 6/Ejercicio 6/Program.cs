using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que tenga el siguiente menu disponible (tiene cinco opciones)
             *              MENU
             *      1.SUMA
             *      2.RESTA
             *      3.MULTIPLICACION
             *      4.DIVISION
             *      5.SALIR
             
             * Si el usuario elije cualquiera de esas opciones debe pedir dos numeros y realizar la operacion que se indico
             * El menu debe estar activo indefinidamente hasta que se elija la opcion salir
             */
            int opcion;
            double n1, n2, resultado;

            do
            {
                Console.WriteLine("\tMENU");
                Console.WriteLine("1.SUMA");
                Console.WriteLine("2.RESTA");
                Console.WriteLine("3.MULTIPLICACION");
                Console.WriteLine("4.DIVISION");
                Console.WriteLine("5.SALIR");
                Console.WriteLine();
                Console.Write("OPCION: "); opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese dos numeros: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    n2 = Convert.ToDouble(Console.ReadLine());
                    resultado = (n1 + n2);
                    Console.WriteLine("RESULTADO: " + resultado);
                }
                else
                {
                    if (opcion == 2)
                    {
                        Console.WriteLine("Ingrese dos numeros: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        n2 = Convert.ToDouble(Console.ReadLine());
                        resultado = (n1 - n2);
                        Console.WriteLine("RESULTADO: " + resultado);
                    }
                    else
                    {
                        if (opcion == 3)
                        {
                            Console.WriteLine("Ingrese dos numeros: ");
                            n1 = Convert.ToDouble(Console.ReadLine());
                            n2 = Convert.ToDouble(Console.ReadLine());
                            resultado = (n1 * n2);
                            Console.WriteLine("RESULTADO: " + resultado);
                        }
                        else
                        {
                            if (opcion == 4)
                            {
                                Console.WriteLine("Ingrese dos numeros: ");
                                n1 = Convert.ToDouble(Console.ReadLine());
                                n2 = Convert.ToDouble(Console.ReadLine());
                                resultado = (n1 / n2);
                                Console.WriteLine("RESULTADO: " + resultado);
                            }
                            else
                            {
                                if (opcion != 5)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("OPCION INVALIDA");
                                }
                            }
                        }
                    }
                }
                if(opcion == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("VUELVA PRONTO!");
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 5);

        }
    }
}
