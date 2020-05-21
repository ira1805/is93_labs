using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_
{
    class Program
    {

        static void Main(string[] args)
        {
            Math m =new Math();
            double a ;
            double b;
            int ch;
            m.Notify += DisplayMessage;
            while (true)
            {
                a = 0;
                b = 0;
                Console.WriteLine("[1] - Сложение");
                Console.WriteLine("[2] - Вычитание");
                Console.WriteLine("[3] - Умножение");
                Console.WriteLine("[4] - Деление");
                Console.WriteLine("[0] - Выход");
                Console.WriteLine("Введите действие");
                ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 0) break;
                Console.WriteLine("Введите число а");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число b");
                b = Convert.ToDouble(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Результат операции {0}",m.Add(a,b));
                    break;
                    case 2:
                        Console.WriteLine("Результат операции {0}", m.Substraction(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Результат операции {0}", m.Multiplication(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Результат операции {0}", m.Division(a, b));
                        break;
                }
            }
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
