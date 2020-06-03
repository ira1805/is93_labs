#include <iostream>
#include "CharList.h"
#include <array>
using namespace std;

int main()
{
    setlocale(0, "ru");
    cout << "Мулiк Рустам IС-93\n_______________________________________\n\n";
    short arr[] = { 5, 3, 8, 6, 38, 60, 49, 1 };
    int size = sizeof(arr) / sizeof(arr[0]);
    List list;
    list.initList(arr, size);
    cout << "список: " << list.OutputList();
    cout << "\nкiлькiсть елементiв, кратних 7: " << list.Divaded(7);
    list.MoreThanMiddle();
    cout << "\nсписок пiсля замiни елементiв бiльших за середнє значення на 0:\n" << list.OutputList();

    system("pause");
}