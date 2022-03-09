//sinonimo de index, hacemos referencia a la pantalla principal o vista de inicio de una aplicacion
//es decir el home del programa de donde arranca
public class Index {
    public static void main (String args[]){
        int n1, n2;
        //incremento despues de la asignación o preincremento
        n1 = 10;
        n2 = n1++;
        System.out.println("n1 = "+n1);
        System.out.println("n2 = "+n2);
        //en este proceso, se incrementa posterior a la asignación el valor de n1
        
        //incremento antes de la asignacion, o postincremento
        n1 = 20;
        n2 = ++n1;
        System.out.println("n1 = "+n1);
        System.out.println("n2 = "+n2);
        
        //contrariedad mediante !
        var flag1 = true;
        var flag2 = !flag1;
        System.out.println("flag1 = "+flag1);
        System.out.println("flat2 = "+flag2);
        
        //incrementos y decrementos
        //incrementos es decir, el aumento de n digitos, en una cifra
        //decremento es decir la disminución de n digitos en una cifra
        n1 = 100; n1++; //se le aumenta uno al colocar dos simbolos positivos continuos
        n2 = 200; n2--; //se le reduce uno, al color dos simbolos negativos continuos
        
        System.out.println("Incremento de uno: "+n1);
        System.out.println("Decremento de uno: "+n2);
        n1+=300; //aumento y asignación de un valor distinto
        n2-=400; //disminución y asignacion de un valor distinto
        System.out.println("Incremento de valores distintos: "+n1);
        System.out.println("Decremento de valores distintos: "+n2);
        n2/=n2; //es posible dividir de igual manera para reducir codigo
        n1*=n1; //es posible multiplicar de esta manera para reducir codigo en la programación
        System.out.println("Resultado de n1: "+n1);
        System.out.println("Resultado de n2: "+n2);
    }
}
