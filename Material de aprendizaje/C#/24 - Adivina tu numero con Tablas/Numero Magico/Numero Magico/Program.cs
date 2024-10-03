using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Magico
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,num2,num3,num4,num5,num6, i = 1, suma;

            do
            {
                Console.WriteLine("        PROGRAMA QUE ADIVINA EL NUMERO");
                Console.WriteLine();
                Console.WriteLine("INGRESE UN NUMERO DE 5 DIGITOS, QUE COMIENCE CON 2");
                num = Convert.ToInt32(Console.ReadLine());

                if ((num > 19999) & (num < 30000))
                {
                    i = 11;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("SU NUMERO DEBE COMENZAR CON 2, Y DEBE TENER 5 DIGITOS");
                    Console.WriteLine("POR EJEMPLO: 25468");
                }

                Console.ReadKey();
                Console.Clear();

            } while (i < 10);

            Console.WriteLine("NUMERO DE 5 DIGITOS INGRESADO: " + num);
            Console.WriteLine();

            num2 = ((num - 20000) + 2);

            Console.WriteLine("NUMERO PROPORCIONADO: {0}", num2);
            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();

            i = 1;

            do
            {

                Console.WriteLine("INGRESE UN NUMERO DE 4 DIGITOS");
                num3 = Convert.ToInt32(Console.ReadLine());

                if ((num3 > 999) & (num3 < 10000))
                {
                    i = 11;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("EL NUMERO DEBE TENER 4 DIGITOS");
                    Console.WriteLine("POR EJEMPLO: 4897");

                    Console.ReadKey();
                    Console.Clear();
                }

            } while (i < 10);

            Console.WriteLine();

            num4 = ((9999 - num3));

            Console.WriteLine("NUMERO PROPORCIONADO: {0}", num4);

            Console.ReadKey();
            Console.Clear();

            do
            {

                Console.WriteLine("INGRESE UN NUMERO DE 4 DIGITOS");
                num5 = Convert.ToInt32(Console.ReadLine());

                if ((num5 > 999) & (num5 < 10000))
                {
                    i = 11;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("EL NUMERO DEBE TENER 4 DIGITOS");
                    Console.WriteLine("POR EJEMPLO: 4897");

                    Console.ReadKey();
                    Console.Clear();
                }

            } while (i < 10);

            Console.WriteLine();

            num6 = ((9999 - num5));

            Console.WriteLine("NUMERO PROPORCIONADO: {0}", num6);

            Console.ReadKey();
            Console.Clear();

            suma = (num2 + num3 + num4 + num5 + num6);

            Console.WriteLine("EL NUMERO *MAGICO* ES: " + suma);

            Console.ReadKey();
        }
    }
}
