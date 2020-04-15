using System;
using Prog2_Lab5_1_Cs_Lib;

namespace Prog2_Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стеблянко Олександр, Лабораторна 4, Варіант 9 \n");

            Console.WriteLine("Створений квадрат A:");
            Square A = new Square(new int[4, 2] { { 3, 0 }, { 3, 3 }, { 0, 3 }, { 0, 0 } });
            WriteOut(A);

            Console.WriteLine("Довжина мiж точками:");
            Console.WriteLine(A.Length(0, 1));
            Console.WriteLine("Периметр квадратy A:");
            Console.WriteLine(A.Perimeter());
            Console.WriteLine("Площа квадратy A:");
            Console.WriteLine(A.Area());
            Console.WriteLine();

            Console.WriteLine("Створений рядок D:");
            Symbols D = new Symbols("dahfshsfhs");
            WriteOut(D);

            Console.WriteLine("Створена лiнiя символів В:");
            Symbols B = new Symbols("*$£&)(_*^^#");
            WriteOut(B);

            Console.WriteLine("Довжина лiнiї символiв B:");
            Console.WriteLine(B.Length());
            Console.WriteLine("Кiлькiсть символу *:");
            Console.WriteLine(B.Count());
            Console.WriteLine();

            Console.WriteLine("Створена лiнiя великих літер С:");
            LargeLetters C = new LargeLetters("ФПВЕНРВТУЕВ");
            WriteOut(C);

            Console.WriteLine("Довжина лiнiї великих лiтер C:");
            Console.WriteLine(C.Length());
            Console.WriteLine("Кiлькiсть символу В:");
            Console.WriteLine(C.Count());
            Console.WriteLine();
        }

        // Метод для виведення вешрин квадрату на екран. Поза класу бо використовує консоль.
        static void WriteOut(Square input)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(input.Get(i, j));
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return;
        }

        // Метод для виведення рядка на екран. Працює для похідних класів Symbols і LargeLetters.
        static void WriteOut(Line input)
        {
            char[] line = input.GetWhole();
            for (int j = 0; j < input.Length(); j++)
            {
                Console.Write(line[j]);
            }
            Console.WriteLine();
            return;
        }
    }
}
