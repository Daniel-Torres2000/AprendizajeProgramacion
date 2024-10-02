using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            double area = rect.ObtenArea();
            Console.WriteLine("Resultado del area: " + area);
            Console.ReadKey();
        }
    }
}
