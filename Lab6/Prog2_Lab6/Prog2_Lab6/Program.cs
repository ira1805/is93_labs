using System;
using Prog2_Lab6_Cs_Lib;

namespace Prog2_Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стеблянко Олександр, Лабораторна 4, Завдання 9 \n");

            // Масив об'єктів класу виразу
            Expression[] A = new Expression[3] { 
                new Expression(2, 5, 3, 40), 
                new Expression(1, 0, 0, 5), 
                new Expression(15, 10, 5, 25) 
            };
            // Обчислення виразу для об'єктів та виведення результатів
            
            Console.WriteLine(
                "Результати розрахункiв:\n" +
                A[0].Calculate().ToString()+ "\n" + 
                A[1].Calculate().ToString()+ "\n" + 
                A[2].Calculate().ToString()
                );


            A[0]['c'] = 7;
            Console.WriteLine("Результат першого виразу при змiнi операнди:\n" + A[0].Calculate().ToString());

            // Приклади виразів що призводять до виняткових ситуацій
            // Корінь менше нуля
            Expression Err1 = new Expression(1, 2, 3, 42);
            Console.WriteLine(Err1.Calculate().ToString());
            // Дільник дорівнює нулю
            Expression Err2 = new Expression(0, 0, 0, 41);
            Console.WriteLine(Err2.Calculate().ToString());
        }
    }
}
