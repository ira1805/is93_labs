#include "pch.h"
#include "Cusque.h"

Node::Node(double inVal, Node* inNext = nullptr, Node* inPrev = nullptr)
{
    val = inVal;
    next = inNext;
    prev = inPrev;
}
// Вставка в початок списку
Node* Node::NewPrev(double value)
{
    prev = &Node(value, this);
    return prev;
}
// Пошук максисума
Node* Node::FindMax(Node* max)
{
    if (val > (*max).val) { max = this; }
    if (next == nullptr) { return max; }
    else { return (*next).FindMax(max); }
}
// Видалення елементу зі списку
void Node::Eliminate()
{
    if (next != nullptr) { (*next).prev = prev; }
    if (prev != nullptr) { (*prev).next = next; }
}


// Вставка в початок списку
void Cusque::NewHead(double val)
{
    Node* newNode = (*head).NewPrev(val);
    head = newNode;
}
Cusque::Cusque(double val)
{
    Node n = Node(val);
    head = &n;
    tail = &n;
}
// Видалення елементiв після максимального
void Cusque::ElimAfterMax()
{
    Node* Max = (*head).FindMax(head);
    (*Max).next = nullptr;
    tail = Max;
}
// Пошук середнього значення
double Cusque::FindAverage()
{
    double avg = 0;
    int count = 0;
    Node* cur = head;
    while (cur != nullptr)
    {
        avg += (*cur).val;
        cur = (*cur).next;
        count += 1;
    }
    avg = avg / count;
    return avg;
}
// Видалення елементів менше середнього
void Cusque::ElimBelowAverage()
{
    double average = FindAverage();
    Node* cur = head;
    while (cur != nullptr)
    {
        if ((*cur).val < average)
        {
            (*cur).Eliminate();
            if (tail == cur) { tail = (*cur).prev; }
            if (head == cur) { head = (*cur).next; }
        }
        cur = (*cur).next;
    }
}
// Запис значень списку в масив
double* Cusque::MakeValueArray()
{
    int count = 0;
    Node* cur = head;
    while (cur != nullptr)
    {
        cur = (*cur).next;
        count += 1;
    }
    cur = head;
    double* valarray = new double[count];
    for (int i = 0; i < count; i++)
    {
        valarray[i] = (*cur).val;
        cur = (*cur).next;
    }
    return valarray;
}