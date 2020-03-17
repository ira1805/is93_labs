using System;

namespace laba1
{
    class Program
    {
        public static void Increase(ref int x) //функція збільшення
        {
            int bit = 1, counter = 0;
            while (bit != 0)
            {
                bit = (x >> counter) & 1; //виділення біта
                x ^= 1 << counter; //інверсія
                counter++;
            }
        }

        public static int Compare(int a, int b) //функція відношення
        {
            int bitA = (a >> 15) & 1, bitB = (b >> 15) & 1;
            if (bitA == 0 && bitB == 1)
                return 1;
            else if (bitA == 1 && bitB == 0)
                return 0;
            else
                for (int i = 14; i >= 0; i--) //цикл порівняння
                {
                    bitA = (a >> i) & 1;
                    bitB = (b >> i) & 1;
                    if (bitA != bitB && bitA == 1)
                        return 1;
                    else if (bitA != bitB)
                        return 0;
                }
            return 0;
        }
        static void Main()
        {
            int a = 2, b = 15, c = 14;
            Increase(ref a);
            Console.WriteLine("Baranov Dmytro, IS-93");
            Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine(Compare(b, c));
            Console.ReadKey();
        }
    }
}
