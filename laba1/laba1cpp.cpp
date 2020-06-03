#include <iostream>

using namespace std;

void compare(int* a, int* b, bool* result)
{
	int bitA = (*a >> 31) & 1, bitB = (*b >> 31) & 1;
	if (bitA < bitB)
		*result = true;
	else if (bitA > bitB)
		*result = false;
	else
		for (int i = 30; i >= 0; i--)
		{
			bitA = (*a >> i) & 1;
			bitB = (*b >> i) & 1;
			if (bitA != bitB && bitA == 1)
			{
				*result = true;
				i = 0;
			}
			else if (bitA != bitB)
			{
				*result = false;
				i = 0;
			}
		}
}

int sum(int a, int b)
{
	int counter;
	while (b != 0) {
		counter = a & b;
		a = a ^ b;
		b = counter << 1;
	}
	return a;
}

void res(bool result)
{
	if (result == 1)
		cout << "Твердження дiйсне\n\n";
	else
		cout << "Твердження хибне\n\n";
}

void input(int* a, int* b)
{
	cout << "Введiть значення операнда 1: ";
	cin >> *a;
	cout << "Введiть значення операнда 2: ";
	cin >> *b;
}

void main()
{
	setlocale(0, "ru");
	int a, b;
	bool result = false;
	input(&a, &b);
	compare(&a, &b, &result);
	res(result);
	input(&a, &b);
	cout << "Результат додавання: " << sum(a, b) << endl << endl;
	system("pause");
}

