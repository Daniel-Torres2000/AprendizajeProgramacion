//Un programa que genere una clase con atributos publicos
#include<iostream>
#include<conio.h>
using namespace std;

//generamos una clase "plantilla" la cual a partir de ella podemos generar objetos del mismo
class Perro{
	public:
		char name[25];//atributo
		int edad; //atributo
		void ladrar(); //metodo
};
//generamos el metodo ladrar y le asignamos instrucciones al mismo
void Perro::ladrar(){
	cout<<"GUAU GUAU GUAU"<<endl; //un metodo que no retorna ningun valor pero ejecuta una accion
}

int main(){
	Perro instancia = Perro(); //esto se le denomina instancia, la cual puede cambiar nombre 
	//el identificador
	printf("Write the dog´s name: "); cin>>instancia.name;
	//instancia.name se utiliza la instancia de la clase Perro y se puede acceder
	//a sus metodos y atributos a traves del punto, seguido del nombre del atributo o metodo
	printf("Write the dog´s age: "); scanf("%i",&instancia.edad);
	getch();
	system("cls");
	printf("\tDog´s Information\n");
	printf("Age: %i\n",instancia.edad);
	printf("Name: %s\n",instancia.name);
	instancia.ladrar();
	system("pause");
	return 0;
}
