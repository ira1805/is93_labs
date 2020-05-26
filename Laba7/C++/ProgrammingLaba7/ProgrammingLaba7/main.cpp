//
//  main.cpp
//  ProgrammingLaba7
//
//  Created by Maksim Shershun on 27.05.2020.
//  Copyright © 2020 Maksim Shershun. All rights reserved.
//

#include <iostream>

using namespace std;

class Node {
public:
    char data;
    Node* next;
};

void printList(Node* n) {
    while (n != NULL) {
        cout << n->data << " ";
        n = n->next;
    }
}

int amountOfStars(Node* n) {
    int starsCount = 0;
    while (n != NULL) {
        if(n->data == '*') {
            starsCount += 1;
        }
        n = n->next;
    }
    return starsCount;
}

void removeSymbolsAfterLattice(Node* n) {
    while (n != NULL) {
        if(n->data == '#') {
            n->next = NULL;
        }
        n = n->next;
    }
}

int main()
{
    Node* head = NULL;
    Node* second = NULL;
    Node* third = NULL;
    Node* forth = NULL;
    
    head = new Node();
    second = new Node();
    third = new Node();
    forth = new Node();

    head->data = '*';
    head->next = second;
    
    second->data = '#';
    second->next = third;

    third->data = 's';
    third->next = forth;
    
    forth->data = '*';
    forth->next = NULL;

    printList(head);
    cout << endl;
    cout << "There are " << amountOfStars(head) << " * symbols in your LinkedList" << endl;
    cout << "After removing all elements after # our list looks someting like this" << endl;
    removeSymbolsAfterLattice(head);
    printList(head);
    return 0;
}
