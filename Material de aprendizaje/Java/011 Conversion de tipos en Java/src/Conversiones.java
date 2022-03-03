import java.util.Scanner;
public class Conversiones {
    public static void main(String args[])
    {
        Scanner consola = new Scanner(System.in);
        var edad = Integer.parseInt("75"); //convertimos con parseInt el valor a entero, en este caso un texto que dice 75
        edad = edad - 10; //utilizamos recursividad implementamos la misma variable y le asignamos un nuevo valor
        System.out.println("Su edad se redujo diez años: "+edad); //mostramos datos
        var pi = Double.parseDouble("3.1416"); //convertimos un valor a tipo double
        float radio;
        System.out.print("Digite el radio de una circunferencia: "); radio = consola.nextFloat(); //leemos un valor decimal tipo float
        System.out.println("El area de la circunferencia es pi*r^2 = "+pi+"* ("+radio+")^2 =" + (pi*Math.pow(radio,2)));
        //aqui es posible imprimir los valore sy aplicamos concatenacion como lo visto anteriormente
        //se hace implementacion de la clase Math, propia de Java para utilizar la funcion de potencia (pow) en sus argumentos
        //el primero es el numero base y el segundo es la potencia
    }
}
