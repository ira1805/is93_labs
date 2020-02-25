using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shahovska D., IC-93, Lab_1");
            Console.WriteLine("Enter first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            bool isEqual = Comparison(num1, num2);
            if (isEqual == true)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers aren't equal");
            }

            int sum = Addition(num1, num2);
            Console.WriteLine($"Sum of numbers: {sum}");
        }

        static bool Comparison(int num1, int num2)
        {
            for (int i = 31; i >= 0; i--)
            {
                int a = (num1 >> i) & 1;
                int b = (num2 >> i) & 1;
                if (a != b)
                {
                    return false;
                }
            }
            return true;
        }

        static int Addition(int num1, int num2)
        {
            int count;
            while (num2 != 0)
            {
                count = num1 & num2;
                num1 = num1 ^ num2;
                num2 = count << 1;
            }
            return num1;
        }
    }
}
