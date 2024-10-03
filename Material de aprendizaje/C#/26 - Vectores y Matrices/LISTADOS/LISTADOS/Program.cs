using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTADOS
{
    class Program
    {
        static void Main(string[] args)
        {
            GRAFICO gra = new GRAFICO();

            gra.graf();
            
            DATOS D = new DATOS();
            D.DAT();

            Console.Clear();

            gra.graf();
            
        }
    }
}
