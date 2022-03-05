package Directorio;
import Directorio.DirectorioDatos;
import java.io.IOException;
import java.util.Scanner;
public class Index {
    public static void main (String args[]) throws IOException
    {
        String name;
        int id;
        float salario;
        char simbolo;
        boolean alergico;
        Scanner console = new Scanner(System.in); 
        DirectorioDatos directory = new DirectorioDatos();
        System.out.println("Ejecutando programa directorio de telefonica...");
        System.in.read(); //lectura de una tecla simula getch de c++
        System.out.print("Digite un nombre: "); name = console.nextLine(); //ejecutar una pausa en programa
        directory.setName(name); //aplicar una pausa en programa
        /*
        instanciamos pausas en al ejecución del programa, para poder ver el momento en el que la variable local, de la clase Index
        asignamos el valor al atributo name de la clase DirectoriosDatos
        */
        
        //si arrastramos una clase al lado lateral de la pantalla
        //automaticamente podremos visualizar dos clases 
        //al mismo tiempo es igual de util con manejo de interfaz
        //grafica
        System.out.print("Digite un Id: "); id = console.nextInt();
        directory.setId(id); 
        
        //con esta lectura a una variable vacio vamos a limpiar el buffer de entrada de Scanner
        console.nextLine();
        
        System.out.println("Digite su salario: "); salario = console.nextFloat();
        directory.setPrecio(salario);
        console.nextLine();
        System.out.println("Digite un caracter: "); simbolo = console.nextLine().charAt(0);
        directory.setSimbolo(simbolo);
        console.nextLine();
        System.out.println("Digite si es alergico escribe true sino lo es cero false");
        alergico = console.nextBoolean(); console.nextLine(); directory.setAlergia(alergico);
        
        /*
            NOTA IMPORTANTE EN PROGRAMACION DE LECTURA DE DATOS
            
            LOS VALORES ENTEROS, PROVOCAN SATURAR EL BUFFER DE ENTRADA DE LA CLASE SCANNER
            POR ENDE, ES NECESARIO APLICAR UNA LECTURA VACIA, O SEA
            LEER DATOS SIN ASIGNAR VALOR A NINGUNA VARIABLE, DE MANERA QUE
            LIMPIAMOS EL BUFFER Y SOLUCIONAMOS EL ERROR DE LECTURA DE DATOS
        */
        
        
    }
}
