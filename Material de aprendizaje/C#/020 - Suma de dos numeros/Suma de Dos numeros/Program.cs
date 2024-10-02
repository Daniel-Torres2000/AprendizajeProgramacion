using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_de_Dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma;

            Console.WriteLine("INGRESE UN NUMERO: ");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("INGRESE UN NUMERO: ");
            num2 = Convert.ToInt16(Console.ReadLine());

            suma = num1 + num2;

            Console.WriteLine("EL RESULTADO DE LA SUMA ES: {0}", suma);

            Console.ReadKey();

        }
    }
}
