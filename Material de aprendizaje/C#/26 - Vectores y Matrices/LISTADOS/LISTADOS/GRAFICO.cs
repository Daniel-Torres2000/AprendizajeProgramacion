using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTADOS
{
    class GRAFICO
    {
        public void graf ()
        {
            int n;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            for (int i = 5; i <= 23; i += 3)
            {
                for (int a = 5; a <= 115; a++)
                {
                    Console.SetCursorPosition(a, i);     //LINEAS UNICAMENTE HORIZONTALES
                    Console.Write("_");
                }
            }

            //INICIO DE LINEAS VERTICALES

            for (int i = 5; i <= 10; i += 5)
            {
                for (int a = 6; a <= 23; a++)
                {
                    Console.SetCursorPosition(i, a);    //COLUMNA NO.
                    Console.Write("|");
                }
            }

            for (int i = 35; i <= 75; i += 10)
            {
                for (int a = 6; a <= 23; a++)
                {
                    Console.SetCursorPosition(i, a);    //COLUMNAS CIERRE DE NOMBRE E INICIO DE COLUMNAS DE BIMESTRES
                    Console.Write("|");
                }
            }

            for (int i = 95; i <= 115; i += 20)
            {
                for (int a = 6; a <= 23; a++)
                {
                    Console.SetCursorPosition(i, a);    //COLUMNAS PROMEDIO Y CLASIFICACION
                    Console.Write("|");
                }
            }

            //FIN DE LINEAS VERTICALES

            //INICIO DE ASIGNACION DE TITULOS

            Console.SetCursorPosition(7, 7);
            Console.Write("NO.");
            Console.SetCursorPosition(12, 7);
            Console.Write("NOMBRES DE LOS ALUMNOS");
            Console.SetCursorPosition(38, 7);
            Console.Write("BIM I");
            Console.SetCursorPosition(48, 7);
            Console.Write("BIM II");
            Console.SetCursorPosition(57, 7);
            Console.Write("BIM III");
            Console.SetCursorPosition(68, 7);
            Console.Write("BIM IV");
            Console.SetCursorPosition(82, 7);
            Console.Write("PROMEDIO");
            Console.SetCursorPosition(100, 7);
            Console.Write("CLASIFICACION");

            n = 1;

            for (int i = 7; i <= 10; i += 5)
            {
                for (int a = 10; a <= 22; a += 3)
                {
                    Console.SetCursorPosition(i, a);
                    Console.Write(n);
                    n++;
                }
            }

            //FIN DE ASIGNACION DE TITULOS

            //INICIO DE INGRESO DE DATOS
        }

    }
}
