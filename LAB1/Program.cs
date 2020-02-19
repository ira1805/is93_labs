using System;

namespace Labaratornaya_1_CCS
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number for decrease:  ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Decrease(ref number1);
            Console.WriteLine(" 1) Decrease result =  " + number1.ToString());
            Console.WriteLine();

            Console.Write("Enter the number_2 to compare: ");
            int number_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number_3 to compare ");
            int number_3 = Convert.ToInt32(Console.ReadLine());

            if(Compare(number_2, number_3) == true)
            {
                Console.WriteLine(" A==B ");
            }
            else
            {
                Console.WriteLine(" A!=B ");
            }

            Console.ReadKey();
        }
        static void Decrease(ref int number)
        {
            int bit;
            if (number == 0)
            {
                number = -1;
            }
            else if (number != 0)
            {
                for (int mask = 0; mask < sizeof(int) * 8 - 1; mask++)
                {
                    bit = number & (1 << mask);
                    if (bit > 0)
                    {
                        for (int i = 0; i < mask + 1; i++)
                            number = number ^ (1 << i);
                        break;
                    }
                }

            }
        }
        
        static bool Compare(int a, int b)
        {

            int bitA, bitB;
            for (int i = 31; i >= 0; i--)
            {
                bitA = (a >> i) & 1;
                bitB = (b >> i) & 1;

                if (bitA != bitB)
                    return false;
            }
            return true;
        }


    }
}
