//
//  Text.cpp
//  LALLALAL
//
//  Created by Maksim Shershun on 04.03.2020.
//  Copyright © 2020 Maksim Shershun. All rights reserved.
//

#include "Text.hpp"
#include "MyString.hpp"
#include <vector>

void Text::addRaw(MyString textToAdd) {
    text.push_back(textToAdd);
}

void Text::deleteRaw(int rawToDelete) {
    text.erase(text.begin() + rawToDelete - 1);
}

char* Text::biggestRaw() {
    int biggest = strlen(text[0].myString);
    int biggestIndex = 0;
    for(int i = 0; i < text.size(); i++) {
        if(strlen(text[i].myString) > biggest) {
            biggestIndex = i;
        }
    }
    
    return text[biggestIndex].myString;
}

MyString Text::numberofNumerStrocs() {
    int indexNumerRow = 0;

    for (int i = 0; i < text.size(); i++)
    {
        for (int j = 0; j < strlen(text[i].myString); j++)
        {
            if (text[i].myString[j] > 47 && text[i].myString[j] < 58)
                indexNumerRow = i;
        }
    }
    return text[indexNumerRow].myString;
}

void Text::clearText() {
    text.erase(text.begin(), text.end());
}

int Text::symbolCount() {
    int symbolsCount = 0;
    for(int i = 0; i < text.size(); i++) {
        for(int j = 0; j < strlen(text[i].myString); j++) {
            symbolsCount += 1;
        }
    }
    return symbolsCount;
}

