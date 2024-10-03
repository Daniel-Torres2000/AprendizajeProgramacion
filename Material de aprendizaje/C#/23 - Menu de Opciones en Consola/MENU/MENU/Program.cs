using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU
{
    class Program
    {
        static void Main(string[] args)
        {

            int cont = 1, op2, n1, n2, e, n3, n4, n5, mayor = 0, p, opera;
            string op;

            Console.WriteLine("¿DESEA ENTRAR AL MENU DE OPCIONES? (SI/NO)");
            op = Console.ReadLine();

            if ((op == "si") | (op == "Si") | (op == "sI") | (op == "SI"))
            {

                do
                {
                    Console.Clear();

                    Console.WriteLine("       MENU DE PRO0GRAMAS");
                    Console.WriteLine();
                    Console.WriteLine("1. Numero Mayor, y Numeros Pares e Impares por Rango");
                    Console.WriteLine("2. Un Numero Mayor Que Cero y Sus Divisores");
                    Console.WriteLine("3. Ingreso de Varios Numeros");
                    Console.WriteLine("4. Un Numero Entero Mayor que Cero y Su Factorial");
                    Console.WriteLine("5. SALIR DEL MENU");
                    Console.WriteLine();
                    Console.Write("INGRESE SU OPCION: ");
                    op2 = Convert.ToInt16(Console.ReadLine());

                    Console.Clear();

                    switch (op2)
                    {
                        case 1:

                            Console.WriteLine("PROGRAMA ELEJIDO 1: NUMERO MAYOR Y NUMEROS PARES E IMPARES POR RANGO");
                            Console.WriteLine();
                            Console.Write("INGRESE EL PRIMER NUMERO: ");
                            n1 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("INGRESE EL SEGUNDO NUMERO: ");
                            n2 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine();

                            Console.Clear();

                            if (n1 > n2)
                            {
                                Console.WriteLine("NUMEROS PARES E IMPARES EN EL RANGO: " + n2 + " - " + n1);
                                Console.WriteLine();

                                e = 1;


                                for (int i = (n2 + 1); i < n1; i++)
                                {

                                    if ((i % 2) == 0)
                                    {
                                        Console.WriteLine(e + ". " + i + ": ES PAR");
                                    }
                                    else
                                    {
                                        Console.WriteLine(e + ". " + i + ": ES IMPAR");
                                    }

                                    e += 1;

                                }

                            }
                            else
                            {
                                if (n2 > n1)
                                {

                                    Console.WriteLine("NUMEROS PARES E IMPARES EN EL RANGO: " + n1 + " - " + n2);
                                    Console.WriteLine();

                                    e = 1;


                                    for (int i = (n1 + 1); i < n2; i++)
                                    {

                                        if ((i % 2) == 0)
                                        {
                                            Console.WriteLine(e + ". " + i + ": ES PAR");
                                        }
                                        else
                                        {
                                            Console.WriteLine(e + ". " + i + ": ES IMPAR");
                                        }

                                        e += 1;

                                    }

                                }
                                else
                                {

                                    if (n1 == n2)
                                    {

                                        Console.WriteLine("NUMEROS PARES E IMPARES EN EL RANGO: " + n2 + " - " + n1);
                                        Console.WriteLine();

                                        Console.WriteLine("NO HAY NINGUN VALOR ENTRE LOS RANGOS PARA MOSTRAR");
                                        Console.WriteLine();

                                    }
                                    else
                                    {
                                        Console.WriteLine("VALORES INGRESADOS ERRONEAMENTE");
                                    }
                                }
                            }

                            Console.ReadKey();

                        break;

                        case 2:

                        do
                        {
                            Console.WriteLine("INGRESE UN NUMERO MAYOR QUE CERO");
                            n3 = Convert.ToInt16(Console.ReadLine());

                            if (n3 < 0)
                            {
                                Console.WriteLine("SU NUMERO DEBE SER MAYOR DE CERO");
                            }

                            Console.ReadKey();
                            Console.Clear();

                        } while (n3 < 0);

                        Console.WriteLine("LOS DIVISORES DEL NUMERO INGRESADO SON: ");
                        Console.WriteLine();

                            e = 1;

                        for (int i = 1; i <= n3; i++)
                        {
                            if((n3%i)==0)
                            {
                                Console.WriteLine(e + ". " + i);
                                e = e + 1;
                            }                                   
                        }

                        Console.ReadKey();

                        break;

                        case 3:

                            Console.Write("INGRESE LA CANTIDAD DE NUMEROS QUE INGRESARA: ");
                            p = Convert.ToInt16(Console.ReadLine());
                            Console.Clear();

                            for (int i = 1; i <= p; i++)
                            {
                                Console.Write("INGRESE EL NUMERO ("+i+"): ");
                                n4 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine();

                                if (i == 1)
                                {
                                    mayor = n4;
                                }

                                if(n4>mayor)
                                {
                                    Console.WriteLine("EL NUMERO INGRESADO ES MAYOR QUE EL PRIMERO");
                                }

                            }

                            Console.ReadKey();

                        break;

                        case 4:

                            do
                            {
                                Console.WriteLine("INGRESE UN NUMERO MAYOR QUE CERO");
                                n5 = Convert.ToInt16(Console.ReadLine());

                                if (n5 < 0)
                                {
                                    Console.WriteLine("SU NUMERO DEBE SER MAYOR DE CERO");
                                }

                                Console.ReadKey();
                                Console.Clear();

                            } while (n5 < 0);

                            Console.WriteLine("EL NUMERO INGRESADO FUE: " + n5);
                            Console.WriteLine();

                            opera = n5;

                            for (int i = 1; i < n5; i ++ )
                            {
                                opera = (opera * i);
                            }

                            Console.WriteLine("EL RESULTADO DE FACTORIAL ES: " + opera);

                            Console.ReadKey();

                       break;

                        case 5:

                            cont = 50;

                            Console.WriteLine("GRACIAS POR UTILIZAR NUESTROS SERVICIOS");

                        break;


                    }

                


                 } while (cont < 10);

            }
            else
            {
                if ((op == "no") | (op == "No") | (op == "nO") | (op == "NO"))
                {
                    Console.WriteLine("VUELVA PRONTO");
                }
            }

            

            Console.ReadKey();

        }
    }
}
