#include<iostream>
using namespace std;
int main(){
	system("color e10"); //la clase system cuenta con funciones de la consola
	return 0;
	/*
	Configura los colores predeterminados de primer y segundo plano de la consola.

COLOR [attr]

  attr         Especifica el atributo de color de la salida de consola.

Los atributos de color est�n especificados con DOS d�gitos hexadecimales (el primero
corresponde al segundo plano; el segundo al primer plano). Los d�gitos
pueden coincidir con cualquiera de los siguientes valores:

    0 = Negro       8 = Gris
    1 = Azul        9 = Azul claro
    2 = Verde       A = Verde claro
    3 = Aguamarina        B = Aguamarina claro
    4 = Rojo        C = Rojo claro
    5 = P�rpura     D = P�rpura claro
    6 = Amarillo    E = Amarillo claro
    7 = Blanco      F = Blanco brillante

Si no se indican argumentos, este comando restaura el color que ten�a
cuando se inici� CMD.EXE. Este valor proviene de la ventana de la consola,
el modificador de l�nea de comandos /T o el valor del registro
DefaultColor.

El comando COLOR configura ERRORLEVEL a 1 si se realiza un intento de ejecutar
el comando COLOR con el mismo color de primer y segundo
plano.

Presione una tecla para continuar . . .
	*/
}
