#include <iostream>

using namespace std;

bool Porivnianya(int a, int b);
void Zmenshenya(int& ref);

int main()
{ 
  setlocale(LC_CTYPE, "ukr");
	int number;
	int& ref = number;
	cout << "Введіть цифру для зменшення: ";
	cin >> number;
	Zmenshenya(ref);
	cout << "Цифра після зменшення = " << number << endl;

	int a, b;
	cout << "Введіть цифри для порівняння" << endl;
	cout << "Введіть першу цифру: ";
	cin >> a;
	cout << "Введіть другу цифру: ";
	cin >> b;
	bool result = Porivnianya(a, b);

	if (result)
		cout << "Перша цифра менше за другу цифру" << endl;
	else
		cout << "Перша цифра не менше другої цифри" << endl;

	return 0;
}

	void Zmenshenya(int& ref)
	{
		if (ref == 0)
			ref = -1;
		else
		{
			int Num_i;
			for (int mask = 0; mask < sizeof(int) * 8 - 1; mask++)
			{
				Num_i = ref & (1 << mask);
				if (Num_i > 0)
				{
					for (int i = 0; i < mask + 1; i++)
						ref = ref ^ (1 << i);
					break;
				}
			}
		}
	}
	bool Porivnianya(int a, int b)
	{
		int number_1, number_2;
		bool flag = false;
		for (int mask = sizeof(int) * 8 - 1; mask >= 0; mask--)
		{
			number_1 = a & (1 << mask);
			number_2 = b & (1 << mask);
			if (number_1 < number_2)
			{
				flag = true;
				break;
			}
			else
				if (number_1 > number_2)
				{
					flag = false;
					break;
				}
		}
		return flag;
	}
