#include<iostream>
#include"True.h"
using namespace std;
using namespace New;
int main()
{
	int First;
	cout << "Input the value for first lesson" << endl;
	cin >> First;
	Counter(First);
	cout << "New value = " << First << endl;
	int a;
	int b;
	cout << "Input to value for second lesson: " << endl;
	cin >> a >> b;
	int s = Summa_Bit(a, b);
	cout << "Suma = " << s << endl;
	system("pause");
	return 0;
}