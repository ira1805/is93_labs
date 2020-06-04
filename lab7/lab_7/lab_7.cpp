#include <iostream>

using namespace std;

class Node
{
public: 
	int Data;
	Node* Link;
};

class MyList
{
public:
	Node* FirstElement;

	void AddingAfterFirstElement(int data)
	{
		Node newNode;
		newNode.Data = data;
		newNode.Link = FirstElement->Link;
		FirstElement->Link = &newNode;
	}
	int CountOfPairedElements()
	{
		int result = 0;
		int currentPosition = 1;
		Node* iterator = FirstElement;
		while (iterator->Link != NULL)
		{
			if (iterator->Data % 2 == 0 && currentPosition % 2 == 0)
			{
				result++;
			}
			iterator = iterator->Link;
			currentPosition++;
		}
		return result;
	}
	void DeleteAfterMinELement()
	{
		int min = FirstElement->Data;
		int index = 0;
		Node* iterator = FirstElement;
		int currentPosition = 1;
		while (iterator->Link != NULL)
		{
			if (min > iterator->Data)
			{
				index = currentPosition;
			}
			min = iterator->Data;
			iterator = iterator->Link;
			currentPosition++;
		}
		iterator = FirstElement;
		for (int i = 1; i < index; i++)
		{
			iterator = iterator->Link;
		}
		iterator->Link = NULL;
	}

	void Print()
	{
		Node* iterator = FirstElement;
		while (iterator->Link != NULL)
		{
			cout << iterator->Data << endl;
			iterator = iterator->Link;
		}
		cout << iterator->Data << endl;
	}
};

int main()
{
	MyList list;
	list.FirstElement->Data = 13;
	Node node2;
	Node node3;
	Node node4;
	node2.Data = 16;
	node3.Data = 8;
	node4.Data = 9;
	
	list.FirstElement->Link = &node2;
	node2.Link = &node3;
	node3.Link = &node4;

	cout << "Start List" << endl;
	list.Print();
	list.AddingAfterFirstElement(10);
	cout << "List after adding element" << endl;
	list.Print();
	cout << "List after deleting elements after min element" << endl;
	list.DeleteAfterMinELement();
	list.Print();
}
