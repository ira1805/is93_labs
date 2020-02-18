using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_sharp_
{
    class Program
    {
        static void reduction(ref int num)
        {
            int num_bit = 0;
            int i = 0;
            while (num_bit != 1)
            {
                num_bit = (num >> i) & 1;
                num = num ^ (1 << i);
                i++;
            }
        }
        static int getSum(int num1, int num2)
        {
            int move = 0, sum = 0;
            for (int i = 0; i < sizeof(int) * 8; i++)
            {
                int num1_bit = (num1 >> i) & 1;
                int num2_bit = (num2 >> i) & 1;

                int sum_bits = num1_bit ^ num2_bit ^ move;
                move = move == 0 ? (num1_bit & num2_bit) : (num1_bit | num2_bit);
                sum = sum | (sum_bits << i);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int num_1 = 0;
            int num_2 = 0;

            for (int i = 0; i < 3; i++)
            {
                int num_3 = 0;
                Console.Write("Enter value to be reduced: ");
                num_3 = int.Parse(Console.ReadLine());
                reduction(ref num_3);
                Console.WriteLine("Reduction on 1: " + num_3);
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter value number 1: ");
                num_1 = int.Parse(Console.ReadLine());
                Console.Write("Enter value number 2: ");
                num_2 = int.Parse(Console.ReadLine());
                int sum = getSum(num_1, num_2);
                Console.WriteLine("Sum is: " + sum);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

                


 