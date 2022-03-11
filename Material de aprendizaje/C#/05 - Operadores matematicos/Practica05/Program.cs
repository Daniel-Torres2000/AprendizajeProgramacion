using System;
namespace Public05
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int n1, n2, resultado;
            n1 = 10;
            n2 = 20; //el signo de igual nos permite asignar valores a una variable
            resultado = n1 + n2; // + mas cuando se usa entre variables es un operador de suma
            //tomese en cuenta que no es lo mismo cuand ose concatena una cadena de texto
            string name = "Daniel", lastName = "Torres", nameComplete;
            nameComplete = name + lastName;
            Console.WriteLine("Nombre Completo: "+nameComplete);
            //podemos visualizar que se concatena el nombre pero queda pegado podemos hacer ciertos
            //cambios añadiendo un espacio de texto
            nameComplete = name + " " + lastName;
            Console.WriteLine(nameComplete);
            //aqui unificamos una cadena de texto con un espacio entre nombre y apellido

            //para delimitar operadores de asignación es posible de otra forma reducida
            n1 += n2; //con esto, sumamos automaticamente los dos valores
            //esto aplica para restas, multiplicaciones y divisiones
            resultado *= n1;
            resultado /= n2;
            //y asi sucesivamente con todos los operadores
        }
    }
}
