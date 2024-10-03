using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que pida un numero del 1-10 y muestre si es par o impar utilizando condiciones Si o*/
            int n;
            Console.Write("INGRESE UN NUMERO: ");
            n = Convert.ToInt32(Console.ReadLine());
            if(n==0)
            {
                Console.WriteLine("ES NEUTRO, CERO");
            }
            else
            {
                if((n==1)||(n==3)||(n==5)||(n==7)||(n==9))
                {
                    Console.WriteLine("ES IMPAR");
                }
                else
                {
                    if ((n == 2) || (n == 4) || (n == 6) || (n == 8) || (n == 10))
                    {
                        Console.WriteLine("ES PAR");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
