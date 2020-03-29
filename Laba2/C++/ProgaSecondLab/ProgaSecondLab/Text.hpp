//
//  Text.hpp
//  LALLALAL
//
//  Created by Maksim Shershun on 04.03.2020.
//  Copyright © 2020 Maksim Shershun. All rights reserved.
//

#ifndef Text_hpp
#define Text_hpp

#include <stdio.h>
#include <vector>
#include "MyString.hpp"

class Text {
public:
    std::vector<MyString> text;
    
    void addRaw(MyString textToAdd);
    void deleteRaw(int rawToDelete);
    char* biggestRaw();
    MyString numberofNumerStrocs();
    void clearText();
    int symbolCount();
};

#endif /* Text_hpp */
