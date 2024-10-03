using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que simule ser un sorteo, en el cual las personas ganadores son aquellas que tienen
              18 años de edad, o 35 años de edad
             
             Condiciones Si O */
            int sorteo;
            Console.Write("INGRESE SU EDAD: ");
            sorteo = Convert.ToInt32(Console.ReadLine());

            /*Se utilizara el signo pleca o barra vertical, el cual se lea con la conexion " o ",
             * nos sirve para indicar que sino se cumple una condicion pero la otra si, automaticamente entra a las
             * instrucciones que esten dentro de nuestro if*/
            if((sorteo==18)||(sorteo==35))
            {
                Console.WriteLine("FELICIDADES!!");
            }
            else
            {
                Console.WriteLine("LO SENTIMOS!");
            }
            Console.ReadKey();
        }
    }
}
