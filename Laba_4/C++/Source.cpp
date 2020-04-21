#include<iostream>
#include"Library.h"
#include<vector>
using namespace std;
using namespace New_Library;

int main()
{
	cout << "Samilenko Oleksandr IS-93\n";
	cout << "Input the string: ";
	vector<char>arr;
	for (int j = 0; j < 1000; j++)
	{
		char c;
		c = getchar();
		if (c == '\n')
		{
			arr.push_back('\0');
			break;
		}
		arr.push_back(c);
	}
	Library R1;
	Library R2(arr);
	Library R3(R2);
	R2 = R2 / 2;
	vector<char> c = R2.GetStr();
	for (int i = 0; i < R2.length; i++)
	{
		cout << R2.GetStr()[i];
	}
	cout << endl;
	//vector<char> c2;
	//Library R4(c2);
	R1 = R2 + R3;
	for (int i = 0; i < R1.length; i++)
	{
		cout << R1.GetStr()[i];
	}
	cout << endl;
	system("pause");
	return 0;
}