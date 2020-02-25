#include <iostream>

using namespace std;

int Addition(int num1, int num2);
bool Comparison(int num1, int num2);

int main()
{
	int num1;
	int num2;
	int sum;
	cout << "Shahovska D., IC-93, Lab_1" << endl;
	cout << "Enter first number: ";
	cin >> num1;
	cout << "Enter second number: ";
	cin >> num2;
	bool result = Comparison(num1, num2);
	if (result == true)
	{
		cout << "Numbers are equal" << endl;
	}
	else if (result == false)
	{
		cout << "Numbers aren't equal" << endl;
	}
	sum = Addition(num1, num2);
	cout << "Sum of numbers: " << sum;
}

bool Comparison(int num1, int num2)
{
	for (int i = 31; i >= 0; i--)
	{
		int a = (num1 >> i) & 1;
		int b = (num2 >> i) & 1;
		if (a != b)
		{
			return false;
		}
	}
	return true;
}

int Addition(int num1, int num2)
{
	int count;
	while (num2 != 0)
	{
		count = num1 & num2;
		num1 = num1 ^ num2;
		num2 = count << 1;
	}
	return num1;
}