using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorr = { 1, 2, 3, 4, 5 };
            foreach(int i in vectorr)
            {
                Console.WriteLine("Posición i = {0}", i);
                Console.ReadKey();
            }
        }
    }
}
