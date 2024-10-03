using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que pida un numero del 1-7 y muestre a que dia de la semana corresponde*/
            int dia;
            Console.Write("INGRESE UN NUMERO DEL 1-7: ");
            dia = Convert.ToInt32(Console.ReadLine());

            if(dia == 1)
            {
                Console.WriteLine("ES LUNES");
            }
            if (dia == 2)
            {
                Console.WriteLine("ES MARTES");
            }
            if (dia == 3)
            {
                Console.WriteLine("ES MIERCOLES");
            }
            if (dia == 4)
            {
                Console.WriteLine("ES JUEVES");
            }
            if (dia == 5)
            {
                Console.WriteLine("ES VIERNES");
            }
            if (dia == 6)
            {
                Console.WriteLine("ES SABADO");
            }
            if (dia == 7)
            {
                Console.WriteLine("ES DOMINGO");
            }
            Console.ReadKey();
        }
    }
}
