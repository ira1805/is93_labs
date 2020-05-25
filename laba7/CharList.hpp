#pragma once
using namespace std;

struct node	//list node struct
{
	char data;	//node char
	node* next;	//next node link
};

node* head = 0;	//head link

node* addNode(char _data) {	//add node function
	node* newNode = new node;	//node init
	if (!head)	//check if there're any nodes in list
		head = newNode;	//head now is new (first) node
	newNode->data = _data;	//set data
	newNode->next = 0;	//set link
	return newNode;
}

node* initList(string line) {	//list init from string function
	node* li = 0;
	if (!line.size())	//if string is empty
		return 0;
	for (int i = 0; i < line.size(); i++)
		if (i == 0) {	//if first node
			head = addNode(line[i]);	//init first node (head)
			li = head;
		}
		else {	//if node isn't first
			li->next = addNode(line[i]);	//set next node link
			li = li->next;	//change variable on next node
		}
	return head;
}

string outputList() {
	string s = "";
	node* li = head;
	while (li->next) {	//until node next link's empty
		s += li->data;	//add node content
		li = li->next;	//change on next node
	}
	s += li->data;	//add last node content
	return s;
}

int findFirst(char x) {	//find the first occurrence of char in the list
	int counter = 0;
	node* li = head;
	while (li->next) {	//until the last node in list
		if (li->data == x)	//if node content is equal to the char
			return counter;
		li = li->next;	//change var on next node
		counter++;	//counter increment
	}
	if (li->data == x)	//if the last node content is equal to the char
		return counter;
	return -1;
}

void removeAll(char x) {	//remove all nodes with content that equals the char
	node* p_li = 0;	//previous node
	node* li = head;	//current node var
	if (!head)	//if list is empty
		return;
	while (li->next && li) {//until the last node in list that exist
		if (li->data == x)	//if node content is equal to the char
			if (li == head) {	//if current node is head
				head = li->next;	//now head's next node of current one
				li = head;	//change var on head
			}
			else {	//if current node isn't head
				p_li->next = li->next;	//previous node next link now is current node next link
			}
		p_li = li;	//previous node now is current
		li = li->next;	//current node now is next node of current
	}
	if (li->data == x)	//check the last node
		p_li->next = 0;	//cut the last node
};