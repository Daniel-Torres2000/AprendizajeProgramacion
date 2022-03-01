//Programa que ejecute encapsulamiento en su contenido
//eso quiere decir que protega los atributos y metodos con los que cuenta
#include<iostream>
using namespace std;
class Animal{
	public:
		//utilizamos metodos de tipo publico para que puedan ser los accesores a datos privados
		string getName(); //metodo get, permite acceder al valor de un dato privado de la clase
		void setName(string name_);//metodo setter que permite asignarle un valor a una variable
	private:
		string name; //designamos la variable nombre como privado no es posible acceder a este
		//unicamente se puede acceder mediante un elemento publico de la clase
};
string Animal::getName(){
	return name; //devolvemos el valor de la variable designada
}
void Animal::setName(string name_){
	name = name_; //al atributo privado le asignamos el valor del parametro
}

int main()
{
	Animal gato = Animal(); //instanciamos un objeto llamado gato a partir de la clase animal y otro denominado perro
	Animal perro = Animal();
	perro.setName("guau");
	gato.setName("miau");
	cout<<"El gato dice: "<<gato.getName()<<endl<<"El perro dice: "<<perro.getName()<<endl;
	return 0;
}
