using System;
using Prog2_Lab7_Cs_Lib;

namespace Prog2_Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стеблянко Олександр, Лабораторна 4, Варiант 9 \n");

            Console.WriteLine("Створення списку:");
            Cusque word = new Cusque(20);
            word.NewHead(30);
            word.NewHead(10);
            word.NewHead(5);
            WriteOut(word.MakeValueArray());

            Console.WriteLine("Видалення елементiв пiлся максимального:");
            word.ElimAfterMax();
            WriteOut(word.MakeValueArray());

            Console.WriteLine("Видалення елементiв менших за середнє значення:");
            word.ElimBelowAverage();
            WriteOut(word.MakeValueArray());
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
