//
//  main.cpp
//  Second Laba Proga
//
//  Created by Maksim Shershun on 29.02.2020.
//  Copyright © 2020 Maksim Shershun. All rights reserved.
//

#include <iostream>
#include <vector>
#include <stdio.h>
#include "Text.hpp"
#include "MyString.hpp"

using namespace std;

int main(int argc, const char * argv[]) {
    
    Text text;
    
    int numb, count = 0;
    int countRows = 0;
    string start;
    
    cout << "Enter amount of raws: ";
    cin >> countRows;
    
    for (int i = 0; i < countRows; i++) {
        cout << "Enter " << i + 1 << " raw: ";
        cin >> start;
        char* array = new char[start.length()];
        
        for (int i = 0; i < strlen(array); i++)
            array[i] = start[i];
        text.addRaw(array);
        start = "";
    }

    cout << "Enter rows :" << endl;

    for (MyString i : text.text) {
        cout << i.myString << endl;
    }
    cout << "---------------------------" << endl;
    
    cout << "Biggest row is = ";
    cout << text.biggestRaw() << endl;
    
    cout << "Enter deleted row = " ;
    cin >> numb;
    text.deleteRaw(numb);
    cout << "\nAfter deleteting " << numb << " row" << endl;
    for (MyString i : text.text) {
        cout << i.myString << endl;
    }
    cout << "---------------------------" << endl;
    cout << "\nBiggest row = " ;
    cout << text.biggestRaw() << endl;
    cout << "Row of digit = " << text.numberofNumerStrocs().myString << endl;
    cout << "\nAfter cleaning" << endl;
    
    text.clearText();
    for (MyString i : text.text)
    {
        cout << i.myString << endl;
    }
    return 0;
}
