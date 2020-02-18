using System;
using System.Threading;

namespace laba1
{
    internal class Program
    {
        public static void summation_numbers(int num1, int num2, ref int summary)
        {
            
            int bit1, bit2;
            int previous = 0;  // If bit1 and bit2 are equal to 1, then we skip those bits and move to next 
            for (int index = 0; index < sizeof(int) * 8 - 1; index = -~index)
            {
                bit1 = num1 & (1 << index);  // bit1 and bit2 will be equal to 0 or some number
                bit2 = num2 & (1 << index);
                if (bit1 != 0) { bit1 = 1; }
                if (bit2 != 0) { bit2 = 1; }
                if ((bit1 != bit2 && previous == 0) || (bit1 == bit2 && bit1 == 0 && previous == 1))
                {
                    summary |= (1 << index);
                    previous = 0;
                }
                else
                {
                    if (((bit1 == bit2) && bit1 == 1 && previous == 0) || (bit1 != bit2 && previous == 1))
                    {
                        previous = 1;
                    } else if (bit1 == bit2 && bit1 == 1 && previous == 1)
                    {
                        summary |= (1 << index);
                    }
                }
            }
            
        }
        public static bool comparising(int num1, int num2)
        {
            
            bool flag = false;
            for (int index = sizeof(int) * 8; index > 0; index = ~-index)
            {
                int bit1 = num1 & (num1 << index);
                int bit2 = num2 & (num2 << index);
                if (bit1 != 0) { bit1 = 1; }
                if (bit2 != 0) { bit2 = 1; }
                if (bit1 == bit2)
                {
                    flag = true;
                } else
                {
                    return false;
                }
            }
            return flag;
            
        }
        
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first number: ");  // Entering data for summary and comparising
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool resultOfComparising;
            int resultOfSum = 0;

            resultOfComparising = comparising(number1, number2);
            summation_numbers(number1, number2, ref resultOfSum);

            Console.WriteLine("The result of comparising number 1 and number 2 is {0}", resultOfComparising);
            Console.WriteLine("Result of addition is {0}", resultOfSum);
            
        }
    }
}