#include <iostream>

using namespace std;

void GetStringLength(string str)
{
	cout << "String length: " << str.size;
}

int main()
{
	string str = "123h";

	void(*foo)(string);
	foo = &GetStringLength;

	(*foo)(str);
}
