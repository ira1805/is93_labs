  
using System;
using Prog_Lib;

namespace Prog2_Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Створений список:");
            lib word = new lib(25);
            word.NewHead(35);
            word.NewHead(10);
            word.NewHead(7);
            WriteOut(word.FillArray());
            Console.WriteLine("Видаляємо числа після максимального:");
            word.DelAfterMax();
            WriteOut(word.FillArray());
            Console.WriteLine("Видаляємо числа менші за середнє значення:");
            word.DelBelowAverage();
            WriteOut(word.FillArray());
        }
        static void WriteOut(double[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
            return;
        }
    }
}
