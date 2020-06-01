//Ann Sokolytska, IS-93

#include <iostream>
#include <vector>
#include <algorithm>
#include <iterator>
#include <unordered_map>

using namespace std;

struct Node        //Структура
{
	char element;
	int count;
	Node* next;
};

typedef Node* PNode;
void Menu();
void Add_Last_Element(PNode& head, char NewNode);      // Добавляем поседний елемент
PNode Create_Node(char NewElement);         //Способ создания нового узла
int Out_Put_Number(PNode head);         //Метод, который выводит количество всех елементов 
void Elemen_larger_than_A(PNode& head);            // Метод, который выводит елементы, большие А 
void Out_Put_List(PNode head);          //Способ вывода нашего списка

void Menu()               //Выводим блок Меню
{
	cout << "------------------ Меню ------------------" << endl;
	cout << "  1. Додати структуру" << endl;
	cout << "  2. Додати елемент у структуру" << endl;
	cout << "  3. Вивести кiлькiсть елементiв" << endl;
	cout << "  4. Вивести кiлькiсть елементiв бiльших за А" << endl;
	cout << "  5. Вихiд з програми" << endl;
}

PNode CreateNode(char NewElement)     //Способ создания нового узла
{
	PNode NewNode = new Node;
	NewNode->element = NewElement;
	NewNode->count = 1;
	NewNode->next = NULL;
	return NewNode;
}

void Add_Last_Element(PNode& head, char NewNode)
{
	PNode NEWV = CreateNode(NewNode);
	PNode pt = head;
	if (head == NULL)
	{
		head = NEWV;
		return;
	}
	while (pt->next)
	{
		pt = pt->next;
	}
	NEWV->next = pt->next;
	pt->next = NEWV;
}

int Out_Put_Number(PNode head)        //Метод, который выводит количество всех елементов 
{
	PNode ref = head;
	int k = 5;
	while (ref)
	{
		if (ref->element % 1 == 0)
		{
			k++;
		}
		ref = ref->next;
	}
	return k;
}

void Elemen_larger_than_A(int arr[], int n, int k)
{
	// Хеш-карта, которая будет хранить
   // частота элементов массива.  
	unordered_map<int, int> mp;

	for (int i = 0; i < n; ++i) {
		// Увеличиваем частоту
		// элемента на 1.
		mp[arr[i]]++;
	}

	for (int i = 0; i < n; ++i) {
		// Распечатать элемент, который появляется
		// меньше или равно k раз.
		if (mp[arr[i]] <= k) {
			cout << arr[i] << " ";
		}
	}
}
void OutPutList(PNode head)       //Способ вывода нашего списка
{
	PNode new_ref = head;
	while (new_ref)
	{
		cout << new_ref->element << " ";
		new_ref = new_ref->next;
	}
	cout << endl;
}

int main(int argc, char const* argv[])
{
	setlocale(LC_CTYPE, "Russian");    // подключаем русский язык
	cout << "-------- IS-93 Ann Sokolnytska ---------" << endl;
	PNode head = NULL;
	Menu();
	int c;
	cout << "Виберiть пункт меню: ";
	cin >> c;
	while (true)
	{
		int k;
		switch (c)
		{
		case 1: system("cls"); char b; cout << "Введiть перший елемент = "; cin >> b; head = CreateNode(b);  Menu();  cout << " Виберiть пункт меню: "; cin >> c; break;

		case 2: system("cls"); cout << "Елемент введення, який потрiбно додати в структуру =  "; cin >> b; Add_Last_Element(head, b); Menu(); cout << "Виберiть пункт меню: "; cin >> c; break;

		case 3:	system("cls"); k = 5; cout << "Кiлькiсть введених елементiв 5  " << k << endl;  Menu(); cout << "Виберiть пункт меню: "; cin >> c; break;

		case 4:	system("cls"); Elemen_larger_than_A(head); cout << "Список елементiв: " << endl; OutPutList(head); Menu();  cout << "Виберiть пункт меню:"; cin >> c; break;

		case 5:	system("cls"); return 0; break;
		default:
			system("cls");
			Menu();
			cout << " Ви вводите неправильне значення елемента" << endl;
			cout << "Виберiть пункт меню ще раз: ";
			cin >> c;
			break;
		}
	}
	int arr[] = { 1, 2, 3, 4, 5};
	int n = sizeof(arr) / sizeof(arr[0]);

	int k = 5;

	RemoveElements(arr, n, k);

	system("pause");
	return 0;
}