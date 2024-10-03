using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_DE_UNIDAD_VISUAL
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numero = new int[45];
            int mayor = 0, menor = 9857, rango, intervalus=4, c=1;
            Double intervalo, amplitud, l_r=3.5;
            int[] xi = new int[6];
            int [] f = new int [6];
            int[] fa = new int[6];
            Double[] farp = new Double[6];
            Double[] far = new Double[6];
            Double [] f_r = new Double[6];
            Double[] f_r_p = new Double[6];

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            numero[0] = 6;
            numero[1] = 11;
            numero[2] = 17;
            numero[3] = 7;
            numero[4] = 4;
            numero[5] = 12;
            numero[6] = 11;
            numero[7] = 11;
            numero[8] = 7;
            numero[9] = 6;
            numero[10] = 7;
            numero[11] = 20;
            numero[12] = 4;
            numero[13] = 8;
            numero[14] = 10;
            numero[15] = 12;
            numero[16] = 14;
            numero[17] = 11;
            numero[18] = 8;
            numero[19] = 11;
            numero[20] = 19;
            numero[21] = 12;
            numero[22] = 9;
            numero[23] = 10;
            numero[24] = 8;
            numero[25] = 16;
            numero[26] = 15;
            numero[27] = 9;
            numero[28] = 15;
            numero[29] = 8;
            numero[30] = 15;
            numero[31] = 10;
            numero[32] = 9;
            numero[33] = 6;
            numero[34] = 18;
            numero[35] = 18;
            numero[36] = 10;
            numero[37] = 17;
            numero[38] = 5;
            numero[39] = 18;
            numero[40] = 11;
            numero[41] = 8;
            numero[42] = 9;
            numero[43] = 6;
            numero[44] = 9;

            for(int i = 0; i <= 5; i++)
            {

                f[i] = 0;
                c += 3;

                for(int a = 0; a<=44; a++)
                {

                    if((numero[a]>=c)&&(numero[a]<=c+2))
                    {
                        f[i]++;
                    }

                }

            }

            c = 0;

            for (int i = 4; i <= 21; i++)
            {
                xi[c] = ((i + (i + 2))/2);

                i+= 2;
                c++;

            }

            fa[0] = f[0];

            for (int i = 1; i <= 5; i++)
            {
                fa[i] = fa[i-1] + f[i];
            }

            for (int i = 0; i <= 5; i++)
            {
                far[i] = (fa[i] / 45.00);
                far[i] = Math.Round(far[i], 4);

                farp[i] = (far[i] * 100.00);
                farp[i] = Math.Round(farp[i], 2);
            }

            c = 0;

            for(int i = 0; i <= 5; i++)
            {

                f_r[i] = Convert.ToDouble(f[i] / 45.00);
                f_r[i] = Math.Round(f_r[i], 4);
                f_r_p[i] = Convert.ToDouble(f_r[i] * 100.00);
                f_r_p[i] = Math.Round(f_r_p[i], 2);
                

            }

            for(int i = 0; i <= 44; i ++)
            {

                if ( numero[i] > mayor)
                {
                    mayor = numero[i];
                }

                if (numero[i] < menor)
                {
                    menor = numero[i];
                }

            }

            rango = mayor - menor;

            intervalo = (1 + 3.3)* Math.Log10(45);
            amplitud = Math.Ceiling((rango / intervalo));

            CUADRO fig = new CUADRO();
            fig.figura();

            Console.ForegroundColor = ConsoleColor.Black;

            for (int i = 8; i <= 18; i +=2 )
            {

                Console.SetCursorPosition(6, i);
                Console.Write(l_r + "-");

                l_r = l_r + 3;

                Console.Write(l_r);

                Console.SetCursorPosition(19, i);
                Console.Write(intervalus + "-");

                intervalus += 2;

                Console.Write(intervalus);

                intervalus++;

                Console.SetCursorPosition(30, i);
                Console.Write(f[c]);

                c++;

            }

            c = 0;

            for (int i = 8; i <= 18; i+=2)
            {
                Console.SetCursorPosition(35, i);
                Console.Write(f_r[c]);

                Console.SetCursorPosition(43, i);
                Console.Write(f_r_p[c]+"%");

                Console.SetCursorPosition(52, i);
                Console.Write(fa[c]);

                Console.SetCursorPosition(57, i);
                Console.Write(far[c]);

                Console.SetCursorPosition(65, i);
                Console.Write(farp[c] + "%");

                Console.SetCursorPosition(74, i);
                Console.Write(xi[c]);

                c++;
            }

            Console.SetCursorPosition(5, 21);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("BIENVENIDO, DISFRUTA DEL HERMOSO CUADRO...VUELVA PRONTO");
            Console.ReadKey();

        }
    }
}
