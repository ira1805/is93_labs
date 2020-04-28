using System;
using Prog2_Lab4_Lib;

namespace Prog2_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стеблянко Олександр, Лабораторна 4, Завдання 9 \n");

            Console.WriteLine("Точки трикутника Т1, створеного констр. за замовчуванням:");
            Triangle T1 = new Triangle();
            WriteOut(T1);
            Console.WriteLine("Точки трикутника Т2, створеного констр. з параметрами:");
            Triangle T2 = new Triangle(new int[3, 2] { { 2, 3 }, { 5, -6 }, { 0, 1 } });
            WriteOut(T2);
            Console.WriteLine("Точки трикутника Т3, створеного констр. копiювання:");
            Triangle T3 = new Triangle(T1);
            WriteOut(T3);

            Console.WriteLine("Периметр трикутника Т2:");
            Console.WriteLine(T2.Perimeter());
            Console.WriteLine("Площа трикутника Т2:");
            Console.WriteLine(T2.Area());
            Console.WriteLine();

            Console.WriteLine("Точки трикутника Т3 пiсля множення на 2:");
            T3 = T3 * 2;
            WriteOut(T3);

            Console.WriteLine("Точки трикутника Т1, що дорiвнює сумi Т1 та Т2:");
            T1 = T3 + T2;
            WriteOut(T1);

            Console.WriteLine("Спробуємо створити трикутник з точками на одній лінії:");
            Triangle Err = new Triangle(new int[3, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 } });
            WriteOut(Err);
        }

        // Метод для виведення масиву на екран. Поза класу бо використовує консоль.
        static void WriteOut(Triangle input)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    Console.Write(input.Get(i, j));
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return;
        }
    }
}
