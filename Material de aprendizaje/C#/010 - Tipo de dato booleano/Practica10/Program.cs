using System;
namespace Practica10
{
    public class Program
    {
        public static void Main(String[] args)
        {
            bool flag = true; //false or true, are the values that can have this variable
            //we use the bool variables for logical sentences, and we use the term "flag" to describe
            //this process
            Console.WriteLine(flag);
            flag = !flag; //we asignate a opposite value, that the original value of the variable flag
            //the new value of flag is false
            Console.WriteLine(flag);
        }
    }
}