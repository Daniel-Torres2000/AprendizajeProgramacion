using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de Vectores y variables
            int[] vec1 = new int[5];
            Double[] vec2 = new Double[5];
            int cont;

            //Instrucciones para cambiar de color el fondo de la pantalla
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            //Ingreso de valores al vector 1 y calculo del cuadrado almacenado en el vector 2
            for(cont=0;cont<=4;cont++)
                {
                    //Instrucción para cambiar el color de la letra del mensaje
                    Console.ForegroundColor = ConsoleColor.Blue;

                    //Mensaje para Ingreso de Valores al vector 1
                    Console.Write("Ingrese un numero en la posicion " + cont + ": ");

                    //Instrucción para cambiar el color de la letra del valor ingresado por el usuario
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    //Asignación del valor ingresado por el usuario al vector 1
                    vec1[cont] = Int32.Parse(Console.ReadLine());

                    //Calculo del cuadrado de los valores del vector 1 almacenadolos en vector 2
                    vec2[cont] = Math.Pow(vec1[cont],2);
                }
            //Limpiar pantalla
            Console.Clear();

            //Posiciona el cursor en la columna y fila indicadas (se puede indicar a partir de la columna y fila 0)
            Console.SetCursorPosition(10, 2);

            //Instrucción para cambiar el color de la letra
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine("Vec1");

            //Instrucción para cambiar el color de la letra
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Posiciona el cursor en la columna y fila indicadas (se puede indicar a partir de la columna y fila 0)
            Console.SetCursorPosition(18, 2);
            
            Console.Write("Vec2");

            for(cont=0;cont<=4;cont++)
                {
                    //Posiciona el cursor en la columna y fila indicadas (se puede indicar a partir de la columna y fila 0)
                    Console.SetCursorPosition(11, 3 + cont);

                    //Instrucción para cambiar el color de la letra
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    Console.Write(vec1[cont]);

                    //Posiciona el cursor en la columna y fila indicadas (se puede indicar a partir de la columna y fila 0)
                    Console.SetCursorPosition(19, 3 + cont);

                    //Instrucción para cambiar el color de la letra
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    
                    Console.Write(vec2[cont]);
                }
            Console.ReadKey();

        }
    }
}
