#include<iostream>
#include"True.h"
using namespace std;
using namespace New;
int main()
{
	int f1 = -87;
	int f2 = 511;
	int f3 = 183;
	Counter(f1);
	Counter(f2);
	Counter(f3);
	cout << f1 << " " << f2 << " " << f3 << endl;
	int a;
	int b;
	cout << "Input two values for the second lessons!" << endl;
	cin >> a >> b;
	if (True(a, b) == true)
	{
		cout << "Answer for second question: YES!!!" << endl;
	}
	else
	{
		cout << "Answer for second question: NO!!!\n";
	}
	system("pause");
	return 0;
}