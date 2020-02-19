#include <iostream>
namespace space
{
    void Decrease(int& ref)
    {
        if (ref == 0)
        {
            ref = -1;
        }
        
        else
        {
            int bit;
            for (int mask = 0; mask < sizeof(int) * 8 - 1; mask++)
            {
                bit = ref & (1 << mask);
                if (bit > 0)
                {
                    for (int i = 0; i < mask + 1; i++)
                        ref = ref ^ (1 << i);
                    break;
                }
            }
        }
    }

    bool Compare(int a, int b)
    {


        int bitA, bitB;
        for (int i = 31; i >= 0; i--)
        {
            bitA = (a >> i) & 1;
            bitB = (b >> i) & 1;
            
            if (bitA != bitB)
                return 0;
        }
        return 1;

    }
}