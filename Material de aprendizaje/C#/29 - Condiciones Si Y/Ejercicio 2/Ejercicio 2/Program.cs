using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Condicion Si Y, realizar un programa que pida una edad, y muestre el respectivo rango al que pertenece:
             
               niño = 1-10 años
               adeolescente = 11-17 años
               adulto = 18-40 años
               mayor = 41-en adelante*/

            int edad;

            //La diferencia de no colocar line seguido de write, es que no nos brinda un salto de linea
            Console.Write("INGRESE SU EDAD: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if((edad>=1)&&(edad<=10))
            {
                Console.WriteLine();
                Console.WriteLine("ES UN NIÑO");
            }
            if ((edad >= 11) && (edad <= 17))
            {
                Console.WriteLine();
                Console.WriteLine("ES UN ADELOSCENTE");
            }
            if ((edad >= 18) && (edad <= 40))
            {
                Console.WriteLine();
                Console.WriteLine("ES UN ADULTO");
            }
            if (edad >= 41)
            {
                Console.WriteLine();
                Console.WriteLine("ES MAYOR");
            }
            Console.ReadKey();
         }
    }
}
