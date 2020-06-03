#include <iostream>
#include <string>

using namespace std;

int last_symbol(string str)
{
    return str.length();
}

void main()
{
    setlocale(0, "ru");
    cout << "Мулiк Рустам IС - 93\n_______________________________________\n\n";
    string str;
    cout << "введiть рядок: ";
    cin >> str;
    int(*f)(string) = last_symbol;
    cout << "номер останнього символу: " << f(str) << endl;
    system("pause");
}