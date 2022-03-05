package Directorio;
import Directorio.DirectorioDatos;
import java.util.Scanner;
public class Index {
    public static void main (String args[])
    {
        String name;
        Scanner console = new Scanner(System.in); 
        DirectorioDatos directory = new DirectorioDatos();
        System.out.println("Ejecutando programa directorio de telefonica...");
        System.out.print("Digite un nombre: "); name = console.nextLine(); //ejecutar una pausa en programa
        directory.setName(name); //aplicar una pausa en programa
        System.out.println("Nombre almacenado en el directorio: "+directory.getName());
        /*
        instanciamos pausas en al ejecución del programa, para poder ver el momento en el que la variable local, de la clase Index
        asignamos el valor al atributo name de la clase DirectoriosDatos
        */
    }
}
