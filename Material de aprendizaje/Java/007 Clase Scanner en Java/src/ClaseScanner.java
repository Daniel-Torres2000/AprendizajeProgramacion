import java.util.Scanner; //importamos una librería que implementaremos propia de java para la lectura del teclado o sea informacion
public class ClaseScanner {
    public static void main (String args[])
    {
        Scanner consola = new Scanner(System.in); //generamos la instancia de la clase Scanner en el identificador consola
        //entre parentesis utilizamos el Sistema de lectura para poder almacenar datos en variables
        System.out.print("Digite su usuario: "); //pedimos datos de un usuario
        var usuario = consola.nextLine(); //guardamos los datos del usuario en la variable var que identificara un valor tipo cadena
        System.out.println("Bienvenido "+usuario);
    }
}
