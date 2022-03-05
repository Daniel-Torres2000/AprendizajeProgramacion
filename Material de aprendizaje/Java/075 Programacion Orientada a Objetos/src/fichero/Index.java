package fichero;
import ficheroRecursos.Recursos; //importamos el fichero externo, en el cual contenemos la clase Recursos
//el fichero se llama ficheroRecursos

public class Index {
    public static void main (String args[])
    {
        Recursos obj = new Recursos();
        System.out.println("Clase index la principal");
        //imprimimos los mensajes del fichero de apoyo
        obj.mensaje();
    }
}
