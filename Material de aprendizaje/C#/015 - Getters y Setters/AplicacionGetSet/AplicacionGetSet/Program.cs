using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Length = 10;
            rect.Width = 20;
            double area = rect.ObtenerArea();
            Console.WriteLine("El resultado del area es: " + area);
            Console.ReadKey();
        }
    }
}
