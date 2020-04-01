//
//  main.cpp
//  4LabaShershunMaksim
//
//  Created by Maksim Shershun on 01.04.2020.
//  Copyright © 2020 Maksim Shershun. All rights reserved.
//

#include <iostream>
#include <vector>
#include <stdio.h>
#include <string>

using namespace std;

class Raw {
public:
    vector<string> raws;
    
    Raw() {}//Default Constructor
    
    Raw(vector<string> text) { // Constructor with parametrs
        this->raws = text;
    }
    
    Raw(const Raw &input) { // Copy Constructor
        this->raws = input.raws;
    }
    
    int getLength() {
        int length = 0;
        
        for(int i = 0; i < raws.size(); i++)
            length += raws[i].length();
        
        return length;
    }
    
    Raw operator +(Raw right_val) {
        Raw result;
        result.raws = this->raws;
        
        for (int i = 0; i < right_val.getLength(); i++)
            result.raws.push_back(right_val.raws[i]);
        
        return result;
    }
    
    Raw operator -(char symbol) {
        Raw result;
        result.raws = this->raws;
        
        for (int i = 0; i < result.raws.size(); i++)
            for(int j = 0; j < result.raws[i].length(); j++)
                if(result.raws[i][j] == symbol)
                    result.raws[i].erase(result.raws[i].begin() + j);
                    
        return result;
    }
};

int main(int argc, const char * argv[]) {
    
    cout << "IS-93 Shershun Maksim, 13 variant" << endl;
    
    int rawsAmount = 0;
    vector<string> raws;
    cout << "Enter amount of raws: ";
    cin >> rawsAmount;
    
    for (int j = 0; j < rawsAmount; j++) {
        string raw;
        cin >> raw;
        raws.push_back(raw);
    }
    
    Raw CS1;
    Raw CS2(raws);
    Raw CS3(CS2);
    
    cout << "Length of CS2 = " << CS2.getLength() << endl;
    
    CS2 = CS2 - '1';
    cout << "CS2 after minus operation" << endl;
    for(string raw : CS2.raws) {
        cout << raw << " ";
    }
    
    cout << endl;
    
    CS1 = CS2 + CS3;
    cout << "CS1 after plus operation" << endl;
    for(string raw : CS1.raws) {
        cout << raw << " ";
    }
    
    return 0;
}
