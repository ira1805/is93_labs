#include<iostream>
using namespace std;
struct Node//Struct
{
	short int element;
	int count;
	Node* next;
};
typedef Node* PNode;
void Menu();//Method, wich output menu
void AddLastElement(PNode& head, short int NewNode);//Method, wich add new element in the finish of list
PNode CreateNode(short int NewElement);//Method for create new node
void OutPutList(PNode head);//Method for output our list
int CountMultiples(PNode head);//Method for count of all elemnts, wich multiples of four
void Switch(PNode &head);//Method for switch element, wich has an index of multiples 2
int main()
{
	cout << "Samilenko Oleksandr IS-93"<<endl;
	PNode head = NULL;
	Menu();
	short int c;
	cout << "Select an item of menu ";
	cin >> c;
	while (true)
	{
		int k;
		switch (c)
		{
		case 1: system("cls"); short int b; cout << "Input first element = "; cin >> b; head = CreateNode(b);  Menu();  cout << "Select an item of menu "; cin >> c; break;
		case 2: system("cls"); cout << "Input element, wich you want to add in struct = "; cin >> b;AddLastElement(head, b); Menu(); cout << "Select an item of menu "; cin >> c; break;
		case 3:	system("cls"); k = CountMultiples(head); cout << "Count of elements with multiples of four = " << k << endl;  Menu(); cout << "Select an item of menu "; cin >> c; break;
		case 4:	system("cls"); Switch(head); cout << "List of elements: " << endl; OutPutList(head); Menu();  cout << "Select an item of menu "; cin >> c; break;
		case 5:	system("cls"); return 0; break;
		default:
			system("cls");
			Menu();
			cout << "You inputed not right value of the item" << endl;
			cout<<"Select an item of menu again: ";
			cin >> c;
			break;
		}
	}
	system("pause");
	return 0;
}
PNode CreateNode(short int NewElement)
{
	PNode NewNode = new Node;
	NewNode->element = NewElement;
	NewNode->count = 1;
	NewNode->next = NULL;
	return NewNode;
}
void AddLastElement(PNode& head, short int NewNode)
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
void Menu()
{
	cout << "Menu" << endl;
	cout << "1. Add struct" << endl;
	cout << "2. Add element in struct" << endl;
	cout << "3. Find count of elemnts, wich multiples of four" << endl;
	cout << "4. Switch element on positions wich multiples of two for 0!!" << endl;
	cout << "5. Exit from programm" << endl;
}
int CountMultiples(PNode head)
{
	PNode ref = head;
	int k = 0;
	while (ref)
	{
		if (ref->element % 4 == 0)
		{
			k++;
		}
		ref = ref->next;
	}
	return k;
}
void Switch(PNode &head)
{
	int k = 0;
	PNode ref = head;
	while (ref)
	{
		if (k % 2 == 0)
		{
			ref->element = 0;
		}
		k++;
		ref = ref->next;
	}
}
void OutPutList(PNode head)
{
	PNode new_ref = head;
	while (new_ref)
	{
		cout << new_ref->element << " ";
		new_ref = new_ref->next;
	}
	cout << endl;
}