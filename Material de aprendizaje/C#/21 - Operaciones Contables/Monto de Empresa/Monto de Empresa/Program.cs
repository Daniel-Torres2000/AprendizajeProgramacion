using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monto_de_Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.	UNA EMPRESA QUE SE DEDICA AL CULTIVO DE PRODUCTOS AGRICOLAS, 
                    DESEA DETERMINAR EL MONTO TOTAL DE LA INVERSION QUE SE DEBE REALIZAR, 
                    ESTE DEPENDE DE CIERTOS ASPECTOS COMO LO SON:
                      a.	ALQUILER DE TERRENO 1 CUERDA CUESTA 1000
                      b.	SEMILLAS: 150 EL QUINTAL POR CADA CUERDA
                      c.	SEGURO: 1000 POR CADA CUERDA
                      d.	GASTOS DE SIEMBRA Y CUIDADO: 1500 POR CADA CUERDA
                    SI LA PERSONA DESEA SEMBRAR DETERMINADA CANTIDAD DE CUERDAS. ¿A CUANTO ASCIENDE EL MONTO DE LA INVERSION?
            */

            Int16 cuerda;
            Double alquiler, semillas, seguro, gastos, total;

            Console.WriteLine("INGRESE LA CANTIDAD DE CUERDAS");
            cuerda = Convert.ToInt16(Console.ReadLine());
            alquiler = cuerda * 1000;
            semillas = cuerda * 150;
            seguro = cuerda * 1000;
            gastos = cuerda * 1500;
            total = alquiler + semillas + seguro + gastos;

            Console.WriteLine("ALQUILER: Q" + alquiler);
            Console.WriteLine("SEMILLAS: Q" + semillas);
            Console.WriteLine("SEGURO: Q" + seguro);
            Console.WriteLine("GASTOS DE SIEMBRA Y CUIDADO: Q" + gastos);
            Console.WriteLine("EL TOTAL DEL MONTO ES: Q{0}", total);
            Console.ReadKey();

        }
    }
}
