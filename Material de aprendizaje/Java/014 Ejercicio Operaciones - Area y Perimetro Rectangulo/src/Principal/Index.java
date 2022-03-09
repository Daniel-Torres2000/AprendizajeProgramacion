package Principal;
import OperacionesBasicasMatematicas.Rectangulo;
import java.io.IOException;
public class Index {
    public static void main(String args[]) throws IOException
    {
        Rectangulo figura = new Rectangulo();
        figura.registrarDatos();
        System.in.read();        
    }
}
