using System;
namespace Practica11
{
    public class Program
    {
        public static void Main(String[] args)
        {
            bool flag = false;
            int num = 10;
            flag = num >= 5; //si se cumple la condicion, automaticamente flag cambiara su valor a true
            Console.WriteLine("Value of flag is: " + flag);
        }
    }
}