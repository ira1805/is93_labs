#include <iostream>
#include "mycontainer.h"
#include "mystring.h"

using namespace std;

int main()
{
	setlocale(0, "ru");

	Mycontainer<Mystring> text
		({Mystring("1st string"), 
		Mystring("2nd string"), 
		Mystring("3rd string"), 
		Mystring("4th string"), 
		Mystring("5th string")});

	cout << "Mulik Rustam IS-93\n" << "____________________________________" << "\n\n" << "Абстракция текста:\n\n" << text << "\n\n" << "Введите:\n";
	cout << "1 - чтобы добавить строку\n" << "2 - чтобы удалить строку\n" << "3 - чтобы очистить текст\n" << "4 - чтобы узнать количество символов в тексте\n" << "5 - чтобы найти нужную строку\n" << "6 - чтобы заменить символ\n" << "0 - чтобы прекратить работу\n";
	int x = 0;
	do
	{
		cin >> x;
		if (x == 1) 
		{
			Mystring add;
			cout << "Введите строку которую хотите добавить:\n";
			cin >> add;
			text.addstring(add);   // не добавляет символы после пробела
			cout << text << endl;

		}
		if (x == 2) 
		{
			int del;
			cout << "Введите номер строки которую хотите удалить:\n";
			cin >> del;
			text.erase(del - 1);
			cout << text;		
		}
		if (x == 3)
		{
			text.clear();
		}
		if (x == 4)
		{
			cout << text.count() << endl;  // не считает из новых строк и после очистки
		}
		if (x == 5) 
		{
			int take;
			cout << "Введите номер строки которую хотите получить: ";
			cin >> take;
			cout << endl << text.choosestr(take) << endl;
		}
		if (x == 6)
		{
			char was, will;
			cout << "Введите символ который хотите заменить: ";
			cin >> was;
			cout << "Введите символ который его заменит: ";
			cin >> will;
			text.replace(was, will);  // не заменяет в новой строке
			cout << text;
		}
	} while (x != 0);

	return 0;
}
