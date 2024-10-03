using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 4, r;
            r = (x < y) ? y : x;
            Console.Write(r);
            Console.ReadKey();
        }
    }
}
