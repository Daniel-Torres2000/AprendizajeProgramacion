using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que pida tres numeros y muestre cual es el mayor, el menor y el numero de enmedio*/
            /*Declaramos variables*/
            int n1, n2, n3;

            /*Pedimos que ingrese los datos*/
            Console.WriteLine("Ingrese 3 numeros: ");
            /*Leemos los datos*/
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());

            /*Comprobacion de la posicion de cada numero*/

            /*NUMERO MAYOR*/
            if((n1>n2)&&(n1>n3))
            {
                Console.WriteLine("EL NUMERO MAYOR ES: " + n1);
            }
            else
            {
                if ((n2 > n1) && (n2 > n3))
                {
                    Console.WriteLine("EL NUMERO MAYOR ES: " + n2);
                }
                else
                {
                    if ((n3 > n2) && (n3 > n1))
                    {
                        Console.WriteLine("EL NUMERO MAYOR ES: " + n3);
                    }
                }
            }

            /*NUMERO MENOR*/
            if ((n1 < n2) && (n1 < n3))
            {
                Console.WriteLine("EL NUMERO MENOR ES: " + n1);
            }
            else
            {
                if ((n2 < n1) && (n2 < n3))
                {
                    Console.WriteLine("EL NUMERO MENOR ES: " + n2);
                }
                else
                {
                    if ((n3 < n2) && (n3 < n1))
                    {
                        Console.WriteLine("EL NUMERO MENOR ES: " + n3);
                    }
                }
            }

            /*NUMERO DE EN MEDIO*/
            if ((n1 > n2) && (n1 < n3))
            {
                Console.WriteLine("EL NUMERO DE EN MEDIO ES: " + n1);
            }
            else
            {
                if ((n1 > n3) && (n1 < n2))
                {
                    Console.WriteLine("EL NUMERO DE EN MEDIO ES: " + n1);
                }
                else
                {
                    if ((n2 > n1) && (n2 < n3))
                    {
                        Console.WriteLine("EL NUMERO DE EN MEDIO ES: " + n2);
                    }
                    else
                    {
                        if ((n2 > n3) && (n2 < n1))
                        {
                            Console.WriteLine("EL NUMERO DE EN MEDIO ES: " + n2);
                        }
                        else
                        {
                            if ((n3 > n2) && (n3 < n1))
                            {
                                Console.WriteLine("EL NUMERO DE EN MEDIO ES: " + n3);
                            }
                            else
                            {
                                if ((n3 > n1) && (n3 < n2))
                                {
                                    Console.WriteLine("EL NUMERO DE EN MEDIO ES: " + n3);
                                }
                            }
                        }
                    }
                }
                
            }

            Console.ReadKey();

        }
    }
}
