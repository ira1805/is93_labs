#ifndef LABA2TEXT_MODTEXT_H
#define LABA2TEXT_MODTEXT_H

#include "ModString.h"
#include <cmath>
using namespace std;

class ModText {
private: vector<ModString> text;
public:
    void AddToText(vector<char> chars); // Add a new string to the text
    void ClearText(); // Clean the text
    int SmallestLength(); // Find the smallest length of the string in the text
    void DeleteSpaces(int index); // Delete spaces in the beginning and in the end of string
    int ConsonantsPercent(); // Percent of consonants in the text
    void DeleteString(int index); // Delete certain string from the text
    void DeleteRepeatedSpaces(); // Delete all repeated spaces in the text
    void GetContent(); // Print the text
};

#endif
