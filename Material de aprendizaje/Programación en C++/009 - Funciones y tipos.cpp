#include<iostream>
using namespace std;
//programa que permita trabajar una suma implementando funciones
int suma(int n1, int n2); //declaramos la funcion suma, la cual tiene dos argumentos dentro de paréntesis
//estos dos argumentoos se deben identificar con el tipo y su nombre, en este caso son dos parametros
int main(){
	int n1, n2;
	printf("Digita dos numeros: \n");
	scanf("%i%i",&n1,&n2); //es posible escanear varios valores al mismo tiempo leerlos
	printf("Resultado de la suma: %i\n", suma(n1, n2)); //imprimimos en pantalla la función suma la cual retorna un valor entero
	return 0;
}
int suma(int n1, int n2){
	return n1+n2; //la funcion retornara la operacion sumatoria entre los dos argumentos n1 y n2
}
