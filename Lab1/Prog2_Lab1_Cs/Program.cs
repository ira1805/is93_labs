using System;

namespace Prog2_Lab1_Cs
{
    class Program
    {
        static void plus_one(ref int a)
        {
            int sign = a >> 31;
            for (int i = 0; i <= 31; i++)
            {
                int bit = a & (1 << i);
                a ^= (1 << i);
                // Console.WriteLine(a);
                if ((sign == -1 && bit == (1 << i)) || (sign == 0 && bit == 0)) { return; }
            }
        }
        static bool lesser_than(int a, int b)
        {
            int bitA = a >> 31;
            int bitB = b >> 31;
            if (bitA != bitB)
                return Convert.ToBoolean(bitA);
            else
                for (int i = 14; i >= 0; i--)
                {
                    bitA = (a >> i) & 1;
                    bitB = (b >> i) & 1;
                    if (bitA != bitB)
                        return Convert.ToBoolean(bitB);
                }
            return false;
        }
        static void Main(string[] args)
        {
            int firstnum, secnum, thirdnum;
            Console.Write("Введите число для операції +1: ");
            firstnum = Convert.ToInt32(Console.ReadLine());
            plus_one(ref firstnum);
            Console.WriteLine(firstnum);
            
            Console.Write("Введите перше число для операції <: ");
            secnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите друге число для операції <: ");
            thirdnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Відношення <: " + lesser_than(secnum,
                                                             thirdnum));
        }
    }
}
