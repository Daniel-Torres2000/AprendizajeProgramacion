#include<iostream>
using namespace std;
int main(){
	int op, num1, num2, result;
	cout<<"Calculadora Basica"<<endl;
	cout<<"1. Addition"<<endl;
	cout<<"2. Substraction"<<endl;
	cout<<"3. Multiplication"<<endl;
	cout<<"4. Division"<<endl;
	cout<<"Enter the number option: "; cin>>op;
	system("cls");
	//you have to use the command if to make a fork 
	//the user can use multiple selections to work in the application
	if(op == 1){
		cout<<"Addition"<<endl;
		cout<<"Enter a number: "; cin>>num1;
		cout<<"Enter other number: "; cin>>num2;
		result = num1 + num2;
	}else if(op == 2){
		cout<<"Substraction"<<endl;
		cout<<"Enter a number: "; cin>>num1;
		cout<<"Enter other number: "; cin>>num2;
		result = num1 - num2;
	} else if(op == 3){
		cout<<"Multiplication"<<endl;
		cout<<"Enter a number: "; cin>>num1;
		cout<<"Enter other number: "; cin>>num2;
		result = num1 * num2;
	} else if(op == 4){
		cout<<"Division"<<endl;
		cout<<"Enter a number: "; cin>>num1;
		cout<<"Enter other number: "; cin>>num2;
		result = num1 / num2;
	}
	cout<<"The result of the operation is: "<<result<<endl;
	return 0;
}
