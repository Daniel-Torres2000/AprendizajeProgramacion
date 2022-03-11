using System;
namespace Practica08
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string linea;
            int num = 10;
            linea = "El valor de la variable num: " + num;
            Console.WriteLine(linea); //Podemos concatenar un texto a variables de otros tipos
            //y asi, tambien pueden ser asignados y almacenados en una variable de tipo cadena
            //el valor que almacena la variable linea es El valor de la variable num: 10
        }
    }
}