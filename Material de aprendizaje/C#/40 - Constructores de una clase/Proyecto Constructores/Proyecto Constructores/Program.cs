using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0;
            double S, R, M, D;
            Console.WriteLine("Ingrese el valor de n1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de n2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            COperaciones Proceso = new COperaciones(n1, n2);
            
            S = Proceso.Suma();
            Proceso.Mensaje(); Console.WriteLine("Suma es: " + S);
            R = Proceso.Resta();
            Proceso.Mensaje(); Console.WriteLine("Resta es: " + R);
            M = Proceso.Multiplicacion();
            Proceso.Mensaje(); Console.WriteLine("Multiplicacion es: " + M);
            D = Proceso.Division();
            Proceso.Mensaje(); Console.WriteLine("Division es: " + D);
            Console.ReadKey();
        }
    }
}
