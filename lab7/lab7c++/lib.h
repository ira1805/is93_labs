#pragma once

class Vuzol {
public:
    double val;
    Vuzol* next;
    Vuzol* prev;

    Vuzol(double inVal, Vuzol* inNext = nullptr, Vuzol* inPrev = nullptr);

    Vuzol* NewPrev(double value);

    Vuzol* FindMax(Vuzol* max);

    void Delete();
};

class lib
{
private:

    Vuzol* head;

    Vuzol* tail;

public:
    void NewHead(double val);

    lib(double val);

    void DelAfterMax();

    double FindAverage();

    void DelBelowAverage();
    
    double* MakeValueArray();
    
    Vuzol* Head() { return head; }
    Vuzol* Tail() { return tail; }
};
