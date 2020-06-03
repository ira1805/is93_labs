#include <iostream>
#include <string>
#include <array>

using namespace std;

class List
{
private:
	class Node
	{
	public:
		Node* pNext;
		short data;

		Node(short data, Node* pNext = nullptr)
		{
			this->data = data;
			this->pNext = pNext;
		}
	};
	int Size;
	Node* head;

public:
	List();

	void push_back(short data);

	void initList(short data[], const int size);

	int Divaded(short div);

	void MoreThanMiddle();

	void Change0(short value);

	string OutputList();

	int GetSize() { return Size; }

};


List::List()
{
	Size = 0;
	head = nullptr;
}



void List::push_back(short data)
{
	if (head == nullptr)
	{
		head = new Node(data);
	}
	else
	{
		Node* current = this->head;

		while (current->pNext != nullptr)
		{
			current = current->pNext;
		}
		current->pNext = new Node(data);

	}

	Size++;
}

void List::initList(short data[], const int size)
{
	for (int i = 0; i < size; i++)
	{
		push_back(data[i]);
	}
}

int List::Divaded(short div)
{
	int count = 0;
	Node* current = this->head;

	while (current->pNext != nullptr)
	{
		if (current->data % 7 == 0)
			count++;
		current = current->pNext;
	}
	return count;
}

void List::MoreThanMiddle()
{
	Node* current = head;
	short sum = 0;
	short count = 0;
	while (current->pNext != nullptr)
	{
		sum += current->data;
		count++;
		current = current->pNext;
	}
	current = head;
	while (current->pNext != nullptr)
	{
		if (current->data > (sum / count))
			Change0(current->data);
		current = current->pNext;
	}

}


void List::Change0(short value)
{
	Node* current = head;

	while (current->pNext != nullptr)
	{
		if (current->data == value)
		{
			current->data = 0;
		}
		current = current->pNext;
	}
}

string List::OutputList()
{
	string s = "[";
	Node* current = head;
	while (current->pNext != nullptr)
	{
		s += to_string(current->data) + ", ";
		current = current->pNext;
	}
	s += to_string(current->data) + "]\n";
	return s;
}

