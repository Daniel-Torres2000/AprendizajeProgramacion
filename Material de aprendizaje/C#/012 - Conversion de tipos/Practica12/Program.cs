using System;
namespace Practica12
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string dato = "10";
            int n = int.Parse(dato); //int.Parse es una funcion para convertir un valor a numero Entero
            //este tipo de funcion aplica para varios tipos de variables
            int n2 = Convert.ToInt32(dato); //ConvertTOINT32 es una funcion para convertir a datos enteros
            //con un tamaño de variable mas limitado en numeros, asi tambien estan long, int64 entre otros
            Console.WriteLine("Esto es un texto: " + dato);
            Console.WriteLine("Esta es una variable entera: {0}", n);
            Console.WriteLine("Esta es una variable entera: {0}", n2);

            //aplicaremos el mismo concepto a la inversa
            n2 += 100;
            dato = n2.ToString(); //convertimos el valor numerico a un texto, se mostrara 110 como texto
            Console.WriteLine(dato+200);//aqui no se sumara como un valor numerico, solo se concatenara
        }
    }
}