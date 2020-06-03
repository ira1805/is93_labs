#include <iostream>
#include <string>
#include "classes.h"
using namespace std;

void main()
{
	setlocale(0, "ru");
	cout << "Мулiк Рустам IС - 93\n_______________________________________\n";
	SymbolStrings str("slzyxfjafgsjer;07954-_@%$&()!7912345&");
	cout << str.GetStr() << endl;
	cout << "вiдсортований за спаданням рядок: " << str.Sort() << endl;
	cout << "кiлькiсть символiв = " << str.Length() << endl;
	system("pause");
}