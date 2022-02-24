#include<iostream>
using namespace std;
int main(){
	system("color e10"); //la clase system cuenta con funciones de la consola
	return 0;
	/*
	Configura los colores predeterminados de primer y segundo plano de la consola.

COLOR [attr]

  attr         Especifica el atributo de color de la salida de consola.

Los atributos de color están especificados con DOS dígitos hexadecimales (el primero
corresponde al segundo plano; el segundo al primer plano). Los dígitos
pueden coincidir con cualquiera de los siguientes valores:

    0 = Negro       8 = Gris
    1 = Azul        9 = Azul claro
    2 = Verde       A = Verde claro
    3 = Aguamarina        B = Aguamarina claro
    4 = Rojo        C = Rojo claro
    5 = Púrpura     D = Púrpura claro
    6 = Amarillo    E = Amarillo claro
    7 = Blanco      F = Blanco brillante

Si no se indican argumentos, este comando restaura el color que tenía
cuando se inició CMD.EXE. Este valor proviene de la ventana de la consola,
el modificador de línea de comandos /T o el valor del registro
DefaultColor.

El comando COLOR configura ERRORLEVEL a 1 si se realiza un intento de ejecutar
el comando COLOR con el mismo color de primer y segundo
plano.

Presione una tecla para continuar . . .
	*/
}
