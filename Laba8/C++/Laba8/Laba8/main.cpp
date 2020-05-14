//
//  main.cpp
//  Laba8
//
//  Created by Maksim Shershun on 14.05.2020.
//  Copyright © 2020 Maksim Shershun. All rights reserved.
//

#include <iostream>
#include <string>
#include <vector>

using namespace std;

void (* ClearHandler)(string message);//our delegate

void DisplayMessage(string message) {//function on which our delegate refers
    cout << message << endl;
}

class MyList {
    vector<string> list;
public:
    MyList(string s) {
        list.push_back(s);
    }
    
    void Clear() {
        ClearHandler = DisplayMessage;
        ClearHandler("Clear function was called");
        list.clear();
    }
};

bool Function(const char str[]);//function witch calls throw F delegate
bool (*DelegateExample)(const char str[]);//one more delegate

int main(int argc, const char * argv[]) {
    DelegateExample = Function;
    DelegateExample("ahsbhrvuv31241234g28y46gywbdhwbs1264");
    MyList mylist ("nasifbhiasfas");
    mylist.Clear();
    return 0;
}

bool Function(const char str[]) {
    int numbers = 0, characters = 0;
    for (int i = 0; i < strlen(str); i++) {
        if ((str[i] >= 67 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122)) {
            characters++;
        } else if (str[i] >= 48 && str[i] <= 57) {
            numbers++;
        }
    }
    cout << (characters > numbers ? "There are more characters" : "There are more numbers") << endl;
    return characters > numbers ? 1 : 0;
}
