#include <iostream>
#include <string>

void bitIncrement(int* value)
{
    unsigned mask = 1; 
    for (mask; (*value & mask) != 0; mask <<= 1)
        *value &= ~mask;
    
    *value |= mask;
}



int main(int argc, char* argv[])
{   

    int a = 45;
    bitIncrement(&a);
    std::cout << a;
    return 0;
    
}		