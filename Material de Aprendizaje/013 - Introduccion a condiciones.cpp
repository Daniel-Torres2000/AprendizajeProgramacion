//Elabora un programa que permita digitar dos numeros y compare cual es el mayor de los dos
#include<iostream>
using namespace std;
class Datos{
	public:
		void setNum1(int num1_);
		int getNum1();
		void setNum2(int num2_);
		int getNum2();
		void setXmax(int xmax_);
		int getXmax();
		void solicitarDatos();
		void numMayor();
	private:
		int num1, num2, xmax;
};
void Datos::setNum1(int num1_){
	num1 = num1_;
}
void Datos::setNum2(int num2_){
	num2 = num2_;
}
void Datos::setXmax(int xmax_){
	xmax = xmax_;
}
int Datos::getNum1(){
	return num1;
}
int Datos::getNum2(){
	return num2;
}
int Datos::getXmax(){
	return xmax;
}
void Datos::solicitarDatos(){ //generamos un metodo para solicitar datos y aparte otro logico que evalua el numero mayor
	int num1_, num2_;
	printf("Digita dos numeros: \n");
	scanf("%i%i",&num1_,&num2_);
	setNum1(num1_);
	setNum2(num2_);
	numMayor(); //llamamos a una función de tipo void para cual seguimos el flujo del codigo sin finalizar
}
void Datos::numMayor(){
	//la condicional if permite evaluar un criterio, si se cumple se ejecutan las instrucciones
	//sino se cumple la condición, no es obligatorio utilizar la sentencia else "sino"
	//pero si necesitamos que algun codigo se ejecute en caso de que la condicion no se cumpla
	//hacemos implementacion del codigo dentro de la sentencia else
	if(getNum1()>getNum2()){
		setXmax(getNum1());
	}else if(getNum2()>getNum1()){
		setXmax(getNum2());
	}else{
		setXmax(0);
	}	
}
int main(){
	Datos logica = Datos();
	logica.solicitarDatos();
	system("pause");
	if(logica.getXmax()!=0){
		printf("El valor mayor es: %i\n",logica.getXmax());
	}else{
		printf("Los numeros son identicos\n");
	}
	return 0;
}
