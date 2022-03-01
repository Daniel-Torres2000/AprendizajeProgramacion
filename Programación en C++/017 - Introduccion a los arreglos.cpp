//Arreglos en programacion, nos referimos a pilas de informacion o vectores de datos, un identificador
//que puede almacenar uno o mas datos de ser necesarios
//El programa que se trabajara permitira ingresar 5 nombres distintos, guardarlos en un arreglo y mostrar los datos
#include<iostream>
#include<stdlib.h>
#include<conio.h>
#include<string>
using namespace std;
int main(){
	string nombres[5];
	cout<<"Digite cinco nombres: "<<endl;
	//se debe especificar la posicion del arreglo en la que se desean guardar los datos
	getline(cin,nombres[0]); //se inicializa la posicion uno en el numero cero
	fflush(stdin);
	getline(cin,nombres[1]);
	fflush(stdin);
	getline(cin,nombres[2]);
	fflush(stdin);
	getline(cin,nombres[3]);
	fflush(stdin);
	getline(cin,nombres[4]); //el limite del vector es igual a [n - 1] debido a que inicializamos en la posicion cero 0
	fflush(stdin);
	system("pause"); system("cls");
	cout<<"Nombre[0]: "<<nombres[0]<<endl; //aqui mostramos datos en pantalla almacenados correctamente
	cout<<"Nombre[1]: "<<nombres[1]<<endl;
	cout<<"Nombre[2]: "<<nombres[2]<<endl;
	cout<<"Nombre[3]: "<<nombres[3]<<endl;
	cout<<"Nombre[4]: "<<nombres[4]<<endl;
	return 0;
}
