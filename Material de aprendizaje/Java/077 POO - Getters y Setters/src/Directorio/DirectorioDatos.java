package Directorio;
public class DirectorioDatos {
    private String name; //asignamos el atributo name como un valor privado, solo es posible acceder a el desde un metodo publico propio de la clase
    private int id;
    private float precio;
    private char simbolo;
    private boolean alergia;

    //abajo se documenta el funcionamiento de los getters y setters
    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public float getPrecio() {
        return precio;
    }

    public void setPrecio(float precio) {
        this.precio = precio;
    }

    public char getSimbolo() {
        return simbolo;
    }

    public void setSimbolo(char simbolo) {
        this.simbolo = simbolo;
    }

    public boolean isAlergia() {
        return alergia;
    }

    public void setAlergia(boolean alergia) {
        this.alergia = alergia;
    }
    public String getName() {
        return name; //devolvemos el valor del atributo name
        //esto proporciona seguridad a nuestro codigo, conociendole como encapsulamiento
    }
    public void setName(String name) {
        this.name = name; //accedemos desde un metodo publico, a un atributo privado mediante la palabra reservada this
        //set asigna el valor nuevo a nuestro atributo, el valor del atributo de tipo String
    }
    //concepto metodos getters y setters
}
