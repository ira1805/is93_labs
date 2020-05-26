#pragma once

class Node {
public:
    double val;
    Node* next;
    Node* prev;

    Node(double inVal, Node* inNext = nullptr, Node* inPrev = nullptr);

    Node* NewPrev(double value);

    Node* FindMax(Node* max);

    void Eliminate();
};

class Cusque
{
private:
    // Голова не має попереднього елементу
    Node* head;
    // Хвост не має наступного елементу
    Node* tail;

public:
    void NewHead(double val);

    Cusque(double val);

    void ElimAfterMax();

    double FindAverage();

    void ElimBelowAverage();
    
    double* MakeValueArray();
    
    Node* Head() { return head; }
    Node* Tail() { return tail; }
};

