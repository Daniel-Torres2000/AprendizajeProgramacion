using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_DE_UNIDAD_VISUAL
{
    class CUADRO
    {

        public void figura()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 5; i <= 78; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.Write("_");

                Console.SetCursorPosition(i, 7);
                Console.Write("_");

                Console.SetCursorPosition(i, 9);
                Console.Write("_");

                Console.SetCursorPosition(i, 11);
                Console.Write("_");

                Console.SetCursorPosition(i, 13);
                Console.Write("_");

                Console.SetCursorPosition(i, 15);
                Console.Write("_");

                Console.SetCursorPosition(i, 17);
                Console.Write("_");

                Console.SetCursorPosition(i, 19);
                Console.Write("_");


            }

            for (int i = 6; i <= 19; i++)
            {
                Console.SetCursorPosition(4, i);
                Console.Write("|");

                Console.SetCursorPosition(16, i);
                Console.Write("|");

                Console.SetCursorPosition(28, i);
                Console.Write("|");

                Console.SetCursorPosition(33, i);
                Console.Write("|");

                Console.SetCursorPosition(42, i);
                Console.Write("|");

                Console.SetCursorPosition(49, i);
                Console.Write("|");

                Console.SetCursorPosition(55, i);
                Console.Write("|");

                Console.SetCursorPosition(63, i);
                Console.Write("|");

                Console.SetCursorPosition(72, i);
                Console.Write("|");

                Console.SetCursorPosition(78, i);
                Console.Write("|");


            }

            Console.SetCursorPosition(9, 6);
            Console.Write("L.R");
            Console.SetCursorPosition(21, 6);
            Console.Write("I.C");
            Console.SetCursorPosition(31, 6);
            Console.Write("F");
            Console.SetCursorPosition(37, 6);
            Console.Write("F.R");
            Console.SetCursorPosition(44, 6);
            Console.Write("F.R%");
            Console.SetCursorPosition(51, 6);
            Console.Write("F.A");
            Console.SetCursorPosition(57, 6);
            Console.Write("F.A.R");
            Console.SetCursorPosition(65, 6);
            Console.Write("F.A.R%");
            Console.SetCursorPosition(74, 6);
            Console.Write("X.I");

        }
    }
}
