import java.util.Scanner;
public class Conversiones {
    public static void main (String args[])
    {
        Scanner consola = new Scanner(System.in);
        //es posible convertir un valor numerico a cadena
        var numATexto = String.valueOf(15);
        System.out.println("numATexto es una variable String: "+numATexto);
        //tambien podemos convertir a caracteres, y devolver solo las posiciones deseadas
        var caracterConvert = "HELLO".charAt(0);
        //la iteracion de informacion empieza en el numero cero, siendo así el total de caracteres n el tope como n-1
        //la palabra HELLO tiene n = 5 caracteres, por tanto comienza en cero la letra H y finaliza en la posicion n-1 o sea 4 la letra O
        System.out.println("Caracter de HELLO posicion Cero: "+caracterConvert);
        char caracter;
        System.out.println("DIgita un caracter: "); caracter = consola.nextLine().charAt(0);
        System.out.println("El caracter es: "+caracter);
    }
}
