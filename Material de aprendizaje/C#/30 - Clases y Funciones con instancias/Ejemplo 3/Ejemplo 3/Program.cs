using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programa que explica los atributos de un objeto, y las acciones o metodos que puede tener*/
            Chumano instancia = new Chumano();
            instancia.saludar();
            instancia.comer();
            Console.ReadKey();
        }
    }
}
