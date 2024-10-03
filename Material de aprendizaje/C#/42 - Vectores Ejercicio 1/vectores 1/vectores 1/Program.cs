using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Ingrese diez numeros y almacenelos en un vector, luego
 * muestre el promedio de dichos numeros*/
namespace vectores_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instrucción para definir el vector
            int[] vec1 = new int[10];
            //Declaración de las otras variables
            int suma=0,cont;
            double prom;
            //Instrucción que me permite cambiar el color
            //del fondo de la pantalla
            Console.BackgroundColor = ConsoleColor.White;
            //Limpiar pantalla
            Console.Clear();
            
            //Llenado del vector y calculo de la suma
            //de los numeros
            for (cont=0;cont<=9;cont++)
            {
                //Instrucción permite cambiar el color de la
                //fuente del programa
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine("Ingrese un numero para la posición "+cont);
                Console.ForegroundColor = ConsoleColor.Blue;
                vec1[cont]=Int32.Parse(Console.ReadLine());
                //vec1[cont] = Convert.ToInt32(Console.ReadLine());
                suma = suma + vec1[cont];
            }
            prom = suma / 10;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El promedio de los numeros ingresados es: " + prom);
            Console.ReadKey();
        }
    }
}
