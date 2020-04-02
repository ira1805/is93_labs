#include<iostream>
#include<vector>
#include"Helper.h"
using namespace std;

using namespace Laba_4;
int main()
{
	cout << "Input the string: ";
	vector<char>array;
	Helper CB1;
	Helper CB3(array);
	Helper CB2(CB3);
	for (int i = 0; i < 1000; i++)
	{
		char s;
		s = getchar();
		if (s == '\n')
		{
			array.push_back('\0');
			break;
		}
		array.push_back(s);
	}
	CB3 = CB3 * 2;
	vector<char> c = CB3.Get_str();
	for (int i = 0; i < CB3.length; i++)
	{
		cout << CB3.Get_str()[i];
	}
	cout << endl;
	CB1 = CB2 + CB3;
	for (int i = 0; i < CB1.length; i++)
	{
		cout << CB1.Get_str()[i];
	}
	cout << endl;
	system("pause");
	return 0;
}