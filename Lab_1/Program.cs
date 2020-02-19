using System;

namespace Лаба_1_ПО
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Введiть числа для порiвняння");
            int a =Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введiть числа для суми");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            Pruriv(a, b);
            s=Suma_Bit( x, y);
            Console.WriteLine("Отримана сума других чисел");
            Console.Write(s);
        }
        static void Pruriv(int x ,int y)
        {
            if ((x ^ y) != 0)
            {
                Console.WriteLine(" Першi числа Нерiвнi");
            }
            else
                Console.WriteLine(" Першi числа Рiвнi");
        }
        static int Suma_Bit( int a, int b)
        {
            int carry;
            while (b != 0)
            {
                carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            return a;
        }
    }
}

