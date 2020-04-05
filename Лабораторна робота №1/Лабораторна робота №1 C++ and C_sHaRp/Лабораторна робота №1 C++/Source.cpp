#include<iostream>
#include"True.h"
using namespace std;
using namespace New;
int main()
{
	setlocale(LC_ALL, "rus");
	int First;
	cout << "Роботу виконав: Самiленко Олександр!!!\nГрупа: IC-93;\n Варiант - 21." << endl;
	cout << "Input the value for first lesson" << endl;
	cin >> First;
	Counter(First);
	cout << "New value = " << First << " = ";
	Output(First);
	int a;
	int b;
	cout << "Input to value for second lesson: " << endl;
	cin >> a >> b;
	int s = Summa_Bit(a, b);
	cout << "Suma = " << s << " = ";
	Output(s);
	system("pause");
	return 0;
}