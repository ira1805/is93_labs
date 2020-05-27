#include "lib.h"

Vuzol::Vuzol(double inVal, Vuzol* inNext = nullptr, Vuzol* inPrev = nullptr)
{
    val = inVal;
    next = inNext;
    prev = inPrev;
}
Vuzol*Vuzol::NewPrev(double value)
{
    prev = &Vuzol(value, this);
    return prev;
}
Vuzol* Vuzol::FindMax(Vuzol* max)
{
    if (val > (*max).val) { max = this; }
    if (next == nullptr) { return max; }
    else { return (*next).FindMax(max); }
}
void Vuzol::Delete()
{
    if (next != nullptr) { (*next).prev = prev; }
    if (prev != nullptr) { (*prev).next = next; }
}
void lib::NewHead(double val)
{
    Vuzol* newVuzol = (*head).NewPrev(val);
    head = newVuzol;
}
lib::lib(double val)
{
    Vuzol n = Vuzol(val);
    head = &n;
    tail = &n;
}
void lib::DelAfterMax()
{
    Vuzol* Max = (*head).FindMax(head);
    (*Max).next = nullptr;
    tail = Max;
}
double lib::FindAverage()
{
    double avg = 0;
    int count = 0;
    Vuzol* cur = head;
    while (cur != nullptr)
    {
        avg += (*cur).val;
        cur = (*cur).next;
        count += 1;
    }
    avg = avg / count;
    return avg;
}
void lib::DelBelowAverage()
{
    double average = FindAverage();
    Vuzol* cur = head;
    while (cur != nullptr)
    {
        if ((*cur).val < average)
        {
            (*cur).Delete();
            if (tail == cur) { tail = (*cur).prev; }
            if (head == cur) { head = (*cur).next; }
        }
        cur = (*cur).next;
    }
}
double* lib::MakeValueArray()
{
    int count = 0;
    Vuzol* cur = head;
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
