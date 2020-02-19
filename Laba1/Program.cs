using System;
using System.Runtime.InteropServices;

namespace Laba1ProgaCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Shershun Maksim FIOT IS-93"); 
            
            int firstValue = -43;
            int secondValue = 75;
            int thirdValue = 63;

            increment(ref firstValue);
            increment(ref secondValue);
            increment(ref thirdValue); 
            
            Console.WriteLine(firstValue); 
            Console.WriteLine(secondValue); 
            Console.WriteLine(thirdValue); 
            
            Console.WriteLine((isEqual(25,25)) ? "25 is Equal to 25" : "25 is not Equal to 25" );
            Console.WriteLine((isEqual(69,78)) ? "69 is Equal to 78" : "69 is not Equal to 78" );
            Console.WriteLine((isEqual(24,25)) ? "24 is Equal to 25" : "24 is not Equal to 25" );

            Console.ReadLine();
        }
        
        static void increment(ref int a) 
        {
            int size = Marshal.SizeOf(a) * 8;
            for(int shift = 0; shift < (size - 1); shift++){
                a ^= 1 << shift;
                if (Convert.ToBoolean(((a >> shift) & 1) ^ 0)) break;
            }
            //return a;
        }
 
        static bool isEqual(int num1, int num2)
        {
            bool flag = false;
            for (int index = Marshal.SizeOf(num1) * 8 ; index > 0; index--)
            {
                int bit1 = 1 & (num1 >> index);
                int bit2 = 1 & (num2 >> index);
                if (bit1 == bit2)
                {
                    flag = true;
                } else {
                    return false;
                }

                index = ~-index;
            }

            return flag;
        }
    }
    
}