//
//  main.cpp
//  Laba1Proga
//
//  Created by Maksim Shershun on 12.02.2020.
//  Copyright © 2020 Maksim Shershun. All rights reserved.
//

#include<iostream>
#include "math.h"

using namespace std;

string get_bits(unsigned int x) {
  string ret;
    
  for (unsigned int mask=0x80000000; mask; mask >>= 1)
    ret += (x & mask) ? "1" : "0";
    
  return ret;
}

int ref(int *a, int *b) {
    return *a + *b;
}

bool isEqual(int firstValue, int secondValue) {
    
    string bFirst = get_bits(firstValue);
    string bSecond = get_bits(secondValue);
    
    for(int i = 0; i < bFirst.size(); i++)
        if (bFirst[i] != bSecond[i])
            return false;
    
    return true;
}//where is located local variables

int increment(int a) {
    int size = sizeof(a) * 8;
    for(int shift = 0; shift < (size - 1); shift++) {
        a ^= 1 << shift;
        if(((a >> shift) & 1) ^ 0) break;
    }
    return a;
}

int main()
{
    cout << "Shershun Maksim FIOT IS-93" << endl << endl;
    
    int firstValue = -43;
    int secondValue = 75;
    int thirdValue = 63;
    
    cout << ref(&secondValue, &thirdValue);
     
    cout << increment(firstValue) << endl;
    cout << increment(secondValue) << endl;
    cout << increment(thirdValue) << endl << endl;
    
    cout << (isEqual(25, 25) ? "25 is Equal to 25" : "25 is not Equal to 25") << endl;
    cout << (isEqual(69, 78) ? "69 is Equal to 78" : "69 is not Equal to 78") << endl;
    cout << (isEqual(24, 25) ? "24 is Equal to 25" : "24 is not Equal to 25") << endl;
    
    system("pause");
    return 0;
}
