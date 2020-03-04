#ifndef LABA2STRING_MODSTRING_H
#define LABA2STRING_MODSTRING_H

#include <vector>
#include <algorithm>
#include <iostream>
using namespace std;

class ModString {
private: vector<char> modString;
public:
    ModString(vector<char> letters); // Constructor for user's string
    void DeleteBegAndEnd(); // Delete the first and the last elements of the string
    int ConsonantsAmount(); // Amount of consonants in the string
    int ModLength(); // Length of the string
    void DeleteRepeatSpaces(); // Delete repeated spaces in the string
    void GetContent(); // Print the string
};

#endif
