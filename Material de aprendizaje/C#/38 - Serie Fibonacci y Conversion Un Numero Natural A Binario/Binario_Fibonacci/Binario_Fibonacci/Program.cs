using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binario_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            OPS fibo = new OPS();
            OPS bin = new OPS();
            int i = 1, op;

            do
            {
                Console.WriteLine("      MENU DE OPCIONES: ELIJA SU OPCION");
                Console.WriteLine();
                Console.WriteLine("1. FIBONACCI");
                Console.WriteLine("2. BINARIO");
                Console.WriteLine("3. SALIR");
                Console.WriteLine();
                Console.Write("OPCION: ");

                op = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        fibo.fibonacci();
                        break;
                    case 2:
                        bin.binario();
                        break;
                    case 3:
                        i = 100;
                        break;
                }
            } while (i < 10);
            

        }
    }
}
