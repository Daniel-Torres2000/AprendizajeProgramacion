using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADIVINA_NUMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 8, contador = 0;
            string r;

            Console.WriteLine("PIENSE EN UN NUMERO");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("TABLA A: ");

            for (i = 8; i <= 107; i++)
            {
                if ((i == 16)|(i == 32)|(i == 48)|(i == 64)|(i == 80)|(i == 96))
                {
                    Console.WriteLine();
                    i = i + 7;
                }
                else
                {
                    Console.Write("" + i + "  ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("INDIQUE SI EL NUMERO EN QUE PENSO APARECE EN LA TABLA A(si/no)");
            Console.Write("RESPUESTA: ");
            r = Console.ReadLine();

            if((r=="si")|(r=="SI")|(r=="Si")|(r=="sI"))
            {
                contador = contador + 8;
            }
            else
            {
                if((r=="no")|(r=="NO")|(r=="No")|(r=="nO"))
                {
                    contador = contador + 0;
                }

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TABLA B: ");

            for (i = 32; i <= 107; i++)
            {
                if ((i == 64))
                {
                    i = i + 31;
                }
                else
                {
                    Console.Write("" + i + "  ");
                }

                if ((i == 41)|(i == 51)|(i == 61)|(i == 102))
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("INDIQUE SI EL NUMERO EN QUE PENSO APARECE EN LA TABLA B(si/no)");
            Console.Write("RESPUESTA: ");
            r = Console.ReadLine();

            if ((r == "si") | (r == "SI") | (r == "Si") | (r == "sI"))
            {
                contador = contador + 32;
            }
            else
            {
                if ((r == "no") | (r == "NO") | (r == "No") | (r == "nO"))
                {
                    contador = contador + 0;
                }

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TABLA C: ");

            for (i = 16; i <= 95; i++)
            {
                if ((i == 32) | (i == 64))
                {
                    i = i + 15;
                }
                else
                {
                    Console.Write("" + i + "  ");
                }

                if ((i == 24) | (i == 49) | (i == 58) | (i == 83) | (i == 92))
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("INDIQUE SI EL NUMERO EN QUE PENSO APARECE EN LA TABLA C(si/no)");
            Console.Write("RESPUESTA: ");
            r = Console.ReadLine();

            if ((r == "si") | (r == "SI") | (r == "Si") | (r == "sI"))
            {
                contador = contador + 16;
            }
            else
            {
                if ((r == "no") | (r == "NO") | (r == "No") | (r == "nO"))
                {
                    contador = contador + 0;
                }

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TABLA D: ");
            Console.Write("" + " 2 "+ "  ");


            for (i = 3; i <= 107; i++)
            {

                if (i <= 107)
                {
                    Console.Write("" + i + "  ");

                    if ((i == 18) | (i == 35) | (i == 54) | (i == 71) | (i == 90) | (i == 107))
                    {
                        Console.WriteLine();
                    }
                }

                if(i<107)
                {
                    i = i + 3;

                    Console.Write("" + i + "  ");

                    if ((i == 18) | (i == 35) | (i == 54) | (i == 71) | (i == 90) | (i == 107))
                    {
                        Console.WriteLine();
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("INDIQUE SI EL NUMERO EN QUE PENSO APARECE EN LA TABLA D(si/no)");
            Console.Write("RESPUESTA: ");
            r = Console.ReadLine();

            if ((r == "si") | (r == "SI") | (r == "Si") | (r == "sI"))
            {
                contador = contador + 2;
            }
            else
            {
                if ((r == "no") | (r == "NO") | (r == "No") | (r == "nO"))
                {
                    contador = contador + 0;
                }

            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TABLA E: ");

            for (i = 1; i <= 107; i+=2)
            {
                Console.Write("" + i + "  ");
                if ((i == 17) | (i == 35) | (i == 53) | (i == 71) | (i == 89) | (i == 107))
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("INDIQUE SI EL NUMERO EN QUE PENSO APARECE EN LA TABLA E(si/no)");
            Console.Write("RESPUESTA: ");
            r = Console.ReadLine();

            if ((r == "si") | (r == "SI") | (r == "Si") | (r == "sI"))
            {
                contador = contador + 1;
            }
            else
            {
                if ((r == "no") | (r == "NO") | (r == "No") | (r == "nO"))
                {
                    contador = contador + 0;
                }

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TABLA F: ");

            for (i = 64; i <= 107; i ++)
            {
                Console.Write("" + i + "  ");
                if ((i == 72) | (i == 81) | (i == 90) | (i == 99))
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("INDIQUE SI EL NUMERO EN QUE PENSO APARECE EN LA TABLA F(si/no)");
            Console.Write("RESPUESTA: ");
            r = Console.ReadLine();

            if ((r == "si") | (r == "SI") | (r == "Si") | (r == "sI"))
            {
                contador = contador + 64;
            }
            else
            {
                if ((r == "no") | (r == "NO") | (r == "No") | (r == "nO"))
                {
                    contador = contador + 0;
                }

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("TABLA G: ");

            for (i = 4; i <= 103; i+=8)
            {                
                for (int a = i; a <= i+3; a++)
                {
                    Console.Write("" + a + "  ");
                    if ((a == 20) | (a == 37) | (a == 54) | (a == 71) | (a == 92))
                    {
                        Console.WriteLine();
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("INDIQUE SI EL NUMERO EN QUE PENSO APARECE EN LA TABLA G(si/no)");
            Console.Write("RESPUESTA: ");
            r = Console.ReadLine();

            if ((r == "si") | (r == "SI") | (r == "Si") | (r == "sI"))
            {
                contador = contador + 4;
            }
            else
            {
                if ((r == "no") | (r == "NO") | (r == "No") | (r == "nO"))
                {
                    contador = contador + 0;
                }

            }
            Console.Clear();

            Console.WriteLine("EL NUMERO EN EL QUE ESTABAS PENSANDO ES..." + contador);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
