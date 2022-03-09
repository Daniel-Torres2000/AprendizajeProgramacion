package OperacionesBasicasMatematicas;
import java.util.Scanner;
public class Rectangulo {
    //Desarrollamos una clase llamada Rectangulo en un paquete de java de nombre OperacionesBasicasMatematicas
    //declaramos los atributos y metodos a implementar
    public float base, altura;
    //implementamos getters y setters para el debido encapsulamiento
    public float getBase() {
        return base;
    }

    public void setBase(float base) {
        this.base = base;
    }

    public float getAltura() {
        return altura;
    }

    public void setAltura(float altura) {
        this.altura = altura;
    }
    
    public float areaRectangulo(float altura, float base){
        return altura*base;
    }
    public float perimetroRectangulo(float altura, float base){
        return 2*(altura+base);
    }
    
    public void registrarDatos(){
        Scanner console = new Scanner(System.in);
        float dato;
        System.out.println("\tRegistro de altura y base de la figura: Rectangulo");
        System.out.println("Base: "); dato = console.nextFloat(); //leemos datos
        setBase(dato);
        System.out.println("Altura: "); dato = console.nextFloat();
        setAltura(dato);
        System.out.println("Area Obtenida: "+areaRectangulo(getAltura(),getBase())); 
        System.out.println("Perimetro Obtenido: "+perimetroRectangulo(getAltura(),getBase()));
    }
}
