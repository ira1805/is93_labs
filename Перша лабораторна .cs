using System;


namespace Labs
{
    class Program
    {
        static void BitIncrement(ref int value)
        {
            int mask = 1;
            for (; (value & mask) != 0; mask <<= 1)
                value &= ~mask;
            value |= mask;
        }
        static int Equals(int x, int y)
        {
            return x & y;
        }
        static void Main()
        {
            int value = 0;
            Console.Write("Enter a number to increment: ");
            Int32.TryParse(Console.ReadLine(), out value);
            BitIncrement(ref value);


            int a = 0, b = 0;
            Console.Write("Enter first value: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter second value: ");
            Int32.TryParse(Console.ReadLine(), out b);
            int result = Equals(a, b);

            Console.WriteLine($"Incremented value: {value}");
            Console.WriteLine($"Equals: {result}");
            Console.ReadKey();
        }
    }
}