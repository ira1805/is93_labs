#include <iostream>
#include "LongList.h"
using namespace std;

int main() {
    LongList *test1 = new LongList();
    LongList *test2 = new LongList();
    LongList *test3 = new LongList();
    for (int i = 0; i < 5; i++) {  // Add 5 random numbers to structures
        test1->Add(rand()%100 + 10);
        test3->Add(rand()%100 +10);
    }
    test3->Add(5);
    test2->Add(3);  // Position = 1
    test2->Add(45);  // Position = 2
    test2->Add(30);  // Position = 3
    test2->Add(96);  // Position = 4
    test2->Add(6);  // Position = 5
    test2->Add(5);  // Position = 6
    test2->Add(15);  // Position = 7
    test2->Add(25);  // Position = 8

    cout << "Position of 5: " << test3->GetPosition(5) << endl;
    test1->DeleteGreaterAvg();
    cout << "Amount of elements multiples of 5 that located in even positions: " << test2->FindSpecialElements() << endl;
    test3->Delete(5);
    try {
        cout << "Position of 5: " << test3->GetPosition(5) << endl;
    } catch (const char* msg) {
        cerr << msg << endl;
    }




}
