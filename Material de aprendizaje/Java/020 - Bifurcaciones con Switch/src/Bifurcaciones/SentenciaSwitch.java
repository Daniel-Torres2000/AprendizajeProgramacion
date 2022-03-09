package Bifurcaciones;
public class SentenciaSwitch {
    public static void main(String args[])
    {
        //una sentencia switch es una estructura logica que permite evaluar varios casos y poder
        //retornar instrucciones 
        //la instruccion break permite quebrar o cerrar cada caso al finalizar las instrucciones
        //existe un caso default es el que se ejecuta en caso de "que la opcion no este entre el repertorio"
        int n = 3;
        switch(n)
        {
            case 1: //casos y se digita que tipo de caso evalua numerico, letras, textos
                System.out.println("Primera opcion seleccionada");
                break;
            case 2:
                System.out.println("Segunda opcion seleccionada");
                break; //break hace el cierre de cada uno de los casos, ya no ejecuta el resto de casos solo el actual seleccionado
            case 3:
                System.out.println("Tercera opcion seleccionada");
                break;    
            default:
                System.out.println("Este es el caso predeterminado");
                break;
        }
    }
}
