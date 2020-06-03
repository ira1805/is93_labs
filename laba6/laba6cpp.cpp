#include <iostream>
#include <vector>
#include "viraz.h"
using namespace std;

int main()
{
	setlocale(0, "ru");
	cout << "Мулiк Рустам IС - 93\n_______________________________________\n\n";
	Viraz arr[5];
	cout << "\n\nПерший об'єкт a=0, b=0, c=0";
	arr[0] = Viraz();
	cout << arr[0].Calculator();
	cout << "\nрезультат: " + arr[0].Result();

	cout << "\n\nДругий об'єкт a=1, b=2, c=3";
	arr[1] = Viraz(1, 2, 3);
	cout << arr[1].Calculator();
	cout << "\nрезультат: " + arr[1].Result();

	cout << "\n\nТретiй об'єкт a=5, b=4, c=0";
	arr[2] = Viraz(5, 4, 0);
	cout << arr[2].Calculator();
	cout << "\nрезультат: " + arr[2].Result();

	cout << "\n\nЧетвертий об'єкт a=3, b=-6, c=1";
	arr[3] = Viraz(3, -6, 1);
	cout << arr[3].Calculator();
	cout << "\nрезультат: " + arr[3].Result();

	cout << "\n\nП'ятий об'єкт a=5.4, b=8.45, c=7.35";
	arr[4] = Viraz();
	arr[4].SetVars(5.4, 8.45, 7.35);  // використання методу встановлення значень об’єкта
	cout << arr[4].Calculator();
	cout << "\nрезультат: " + arr[4].Result() << "\n\n";

	system("pause");
	return 0;
}