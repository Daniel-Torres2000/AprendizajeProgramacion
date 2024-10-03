using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binario_Fibonacci
{
    class OPS
    {

        public void fibonacci ()
        {

            int num, a = 0, b = 0;

            Console.WriteLine("INGRESE UN NUMERO");
            num = Convert.ToInt16(Console.ReadLine());

            Console.Write(a + ", ");

            for (int i = 1; i <= num; i+=0)
            {

                if (i <= num)
                {
                    Console.Write(i);
                }

                b = i;

                i = a + i;

                if(i <= num)
                {
                    Console.Write(", ");
                }
                
                a = b;

            }

            Console.ReadKey();
            Console.Clear();

        }

        public void binario ()
        {
            int num;
            String binario = "";
            int res;

            Console.WriteLine("INGRESE UN NUMERO");
            num = Convert.ToInt16(Console.ReadLine());

            res = Convert.ToInt16(num);

            do
            {

                binario = ((res % 2) + binario);

                res = (res / 2);

            } while (res > 0);

            Console.WriteLine("SU NUMERO EN BINARIO ES: " + binario);

            Console.ReadKey();
            Console.Clear();
        }


        


    }
}
