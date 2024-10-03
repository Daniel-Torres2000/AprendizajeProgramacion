using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.	DADA UNA MEDIDA EN PIES, CONVIERTALA A SU EQUIVALENTE EN YARDAS, PULGADAS, CENTIMETROS Y METROS, SABIENDO QUE:
                    a.	1 PIE=12 PULGADAS
                    b.	1 PULGADA=2.54 CENTIMETROS
                    c.	1 METRO = 100 CENTIMETROS
                    d.	1 YARDA=91.44 CENTIMETROS
            */

            Double pie, pul, cm, m, yar;

            Console.WriteLine("INGRESE SU MEDIDA EN PIES");
            pie = Convert.ToDouble(Console.ReadLine());

            pul = pie * 12;
            cm = pul * 2.54;
            m = cm / 100;
            yar = cm / 91.44;

            Console.WriteLine("PULGADAS= " + pul);
            Console.WriteLine("CENTIMETROS= " + cm);
            Console.WriteLine("METROS= " + m);
            Console.WriteLine("YARDAS= " + yar);

            Console.ReadKey();

        }
    }
}
