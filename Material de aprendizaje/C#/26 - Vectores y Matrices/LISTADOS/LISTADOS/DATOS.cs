using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTADOS
{
    class DATOS
    {
        public void DAT()
        {
            Double[,] notas = new Double[5, 5];
            String[] nombres = new String[5];
            Double media = 0, alta = 0, baja = 999, alta2 = 0, baja2 = 999;

            int n, c, b;

            n = 0;
            c = 0;

            Console.SetCursorPosition(38, 10);

            for (int i = 10; i <= 22; i += 3)
            {
                for (int a = 12; a <= 100; a++)
                {
                    Console.SetCursorPosition(a, i);
                    nombres[n] = Console.ReadLine();

                    a = 38;

                    Console.SetCursorPosition(a, i);
                    notas[n, c] = Convert.ToDouble(Console.ReadLine());
                    notas[n, c] = Math.Round(notas[n, c], 1);

                    c++;

                    a = 48;

                    Console.SetCursorPosition(a, i);
                    notas[n, c] = Convert.ToDouble(Console.ReadLine());
                    notas[n, c] = Math.Round(notas[n, c], 1);

                    c++;

                    a = 58;

                    Console.SetCursorPosition(a, i);
                    notas[n, c] = Convert.ToDouble(Console.ReadLine());
                    notas[n, c] = Math.Round(notas[n, c], 1);

                    c++;

                    a = 68;

                    Console.SetCursorPosition(a, i);
                    notas[n, c] = Convert.ToDouble(Console.ReadLine());
                    notas[n, c] = Math.Round(notas[n, c], 1);

                    c++;

                    a = 85;

                    Console.SetCursorPosition(a, i);
                    notas[n, c] = Convert.ToDouble((notas[n, 0] + notas[n, 1] + notas[n, 2] + notas[n, 3]) / 4);
                    notas[n, c] = Math.Round(notas[n, c], 1);
                    Console.Write(notas[n, c]);

                    c = 0;

                    if ((notas[n, 4] >= 0) && (notas[n, 4] <= 59))
                    {
                        Console.SetCursorPosition(100, i);
                        Console.Write("REPROBADO");
                    }
                    else
                    {
                        if ((notas[n, 4] >= 60) && (notas[n, 4] <= 75))
                        {
                            Console.SetCursorPosition(100, i);
                            Console.Write("BIEN");
                        }
                        else
                        {
                            if ((notas[n, 4] >= 76) && (notas[n, 4] <= 85))
                            {
                                Console.SetCursorPosition(100, i);
                                Console.Write("MUY BIEN");
                            }
                            else
                            {
                                if ((notas[n, 4] >= 86) && (notas[n, 4] <= 100))
                                {
                                    Console.SetCursorPosition(100, i);
                                    Console.Write("EXCELENTE");
                                }
                            }
                        }
                    }
                    a = 101;
                }
                n++;
            }
            Console.ReadKey();
            Console.Clear();

            GRAFICO gra = new GRAFICO();
            gra.graf();

            c = 0;
            b = 0;

            for (int i = 10; i <= 22; i += 3)
            {
                for (int a = 12; a <= 100; a++)
                {
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.SetCursorPosition(a, i);
                    Console.Write(nombres[c]);

                    Console.SetCursorPosition(38, i);

                    if ((notas[c, b] >= 0) && (notas[c, b] <= 59))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(notas[c, b]);
                    }
                    else
                    {
                        if ((notas[c, b] >= 60) && (notas[c, b] <= 100))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(notas[c, b]);
                        }
                    }

                    b++;

                    Console.SetCursorPosition(48, i);

                    if ((notas[c, b] >= 0) && (notas[c, b] <= 59))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(notas[c, b]);
                    }
                    else
                    {
                        if ((notas[c, b] >= 60) && (notas[c, b] <= 100))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(notas[c, b]);
                        }
                    }

                    b++;

                    Console.SetCursorPosition(58, i);

                    if ((notas[c, b] >= 0) && (notas[c, b] <= 59))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(notas[c, b]);
                    }
                    else
                    {
                        if ((notas[c, b] >= 60) && (notas[c, b] <= 100))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(notas[c, b]);
                        }
                    }

                    b++;

                    Console.SetCursorPosition(68, i);

                    if ((notas[c, b] >= 0) && (notas[c, b] <= 59))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(notas[c, b]);
                    }
                    else
                    {
                        if ((notas[c, b] >= 60) && (notas[c, b] <= 100))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(notas[c, b]);
                        }
                    }

                    Console.SetCursorPosition(85, i);

                    if ((notas[c, 4] >= 0) && (notas[c, 4] <= 59))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(notas[c, 4]);

                        Console.SetCursorPosition(100, i);
                        Console.Write("REPROBADO");
                    }
                    else
                    {
                        if ((notas[c, 4] >= 60) && (notas[c, 4] <= 75))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(notas[c, 4]);

                            Console.SetCursorPosition(100, i);
                            Console.Write("BIEN");
                        }
                        else
                        {
                            if ((notas[c, 4] >= 76) && (notas[c, 4] <= 85))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(notas[c, 4]);

                                Console.SetCursorPosition(100, i);
                                Console.Write("MUY BIEN");
                            }
                            else
                            {
                                if ((notas[c, 4] >= 86) && (notas[c, 4] <= 100))
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(notas[c, 4]);

                                    Console.SetCursorPosition(100, i);
                                    Console.Write("EXCELENTE");
                                }
                            }
                        }
                    }

                    b = 0;
                    a = 102;
                }
                c++;
            }

            Console.ReadKey();

            media = ((notas[0, 4] + notas[1, 4] + notas[2, 4] + notas[3, 4] + notas[4, 4]) / 5);

            b = 0;
            c = 0;

            for(int i = 0; i <= 4; i++)
            {
                if(notas[i,4]>=alta)
                {
                    alta = notas[i, 4];
                }

                if (notas[i, 4] <= baja)
                {
                    baja = notas[i, 4];
                }
                
            }

            
            Console.SetCursorPosition(12, 25);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("PROMEDIOS:");

            for (int i = 26; i <= 30; i++)
            {
                for(int a = 1; a<=1; a++)
                {
                    Console.SetCursorPosition(12, i);

                    Console.Write("EL PROMEDIO DE "+nombres[c]);

                    if(notas[c,b]==alta)
                    {
                        Console.Write(" ES EL PROMEDIO MAS ALTO, ");
                    }
                    if (notas[c, b] == baja)
                    {
                        Console.Write(" ES EL PROMEDIO MAS BAJO, ");
                    }

                    if(notas[c,b]>=media)
                    {
                        Console.Write(" ESTANDO POR ENCIMA DE LA MEDIA");
                    }
                    else
                    {
                        if (notas[c, b] < media)
                        {
                            Console.Write(" ESTANDO POR DEBAJO DE LA MEDIA");
                        }
                    }

                    c++;
                    b++;

                }
            }

            Console.SetCursorPosition(12, 32);
            Console.Write("BIMESTRES:");

            for (int i = 0; i <= 4; i++)
            {
                if (notas[i, 0] >= alta2)
                {
                    alta2 = notas[i, 0];
                }

                if (notas[i, 0] <= baja2)
                {
                    baja2 = notas[i, 0];
                }
            }

            Console.SetCursorPosition(12, 33);
            Console.Write("BIMESTRE I: NOTA ALTA: "+alta2+", NOTA BAJA: "+baja2);

            for (int i = 0; i <= 4; i++)
            {
                if (notas[i, 1] >= alta2)
                {
                    alta2 = notas[i, 1];
                }

                if (notas[i, 1] <= baja2)
                {
                    baja2 = notas[i, 1];
                }
            }

            Console.SetCursorPosition(12, 34);
            Console.Write("BIMESTRE II: NOTA ALTA: " + alta2 + ", NOTA BAJA: " + baja2);

            for (int i = 0; i <= 4; i++)
            {
                if (notas[i, 2] >= alta2)
                {
                    alta2 = notas[i, 2];
                }

                if (notas[i, 2] <= baja2)
                {
                    baja2 = notas[i, 2];
                }
            }

            Console.SetCursorPosition(12, 35);
            Console.Write("BIMESTRE III: NOTA ALTA: " + alta2 + ", NOTA BAJA: " + baja2);

            for (int i = 0; i <= 4; i++)
            {
                if (notas[i, 3] >= alta2)
                {
                    alta2 = notas[i, 3];
                }

                if (notas[i, 3] <= baja2)
                {
                    baja2 = notas[i, 3];
                }
            }

            Console.SetCursorPosition(12, 36);
            Console.Write("BIMESTRE IV: NOTA ALTA: " + alta2 + ", NOTA BAJA: " + baja2);

            Console.SetCursorPosition(12, 40);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("GOODBYE");

            Console.ReadKey();


        }

    }
}
