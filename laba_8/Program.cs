using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events;

namespace Delegate_cheak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ann Sokolnytska IS-93");
            Console.Write("Bank account = ");
            string s = Console.ReadLine();
            Cheak val = new Cheak();
            DelegeteClass del;
            del = Cheak.FindL;// Добавить новый делегат
            Console.Write("For static mathod: ");
            if (del(s) == true)
            {
                Console.WriteLine(" Bank account has money!");
            }
            else
            {
                Console.WriteLine("Bank account has not money!");
            }

            Console.Write("For examples of class: ");
            del = val.FindL2;// Добавить новый делегат
            if (del(s) == true)
            {
                Console.WriteLine("Bank account has money!!");
            }
            else
            {
                Console.WriteLine("Bank account has not money!!");
            }
            Console.WriteLine("Second exercise!");
            DelegateClear deleg = ClearAll;// Добавить новый метод для делегата, с отправкой в ​​класс
            int c;
            Console.WriteLine("Вы хотите получить кредит? Если да нажмите (+), если нет нажмите (-): ");
            char cr = Convert.ToChar(Console.ReadLine());
            Class1 value;
            if (cr == '+')
            {
                value = new Class1(deleg);// Добавить новый объект Class1 is class
            }
            else
            {
                value = new Class1(); value = new Class1(deleg);// Добавить новый объект Class1 is class

            }
            Menu();
            Console.WriteLine("Выберите пункт меню:");
            c = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (c)
                {
                    case 1: Console.WriteLine("Введите новый счет: "); object obj = Console.ReadLine(); value.AddNewElement(obj); Menu(); Console.Write("Пункт меню: "); c = Convert.ToInt32(Console.ReadLine()); break;
                    case 2: value.DeleteElement(); Menu(); Console.Write("Пункт меню: "); c = Convert.ToInt32(Console.ReadLine()); break;
                    case 3: value.RemoveAll(); Menu(); Console.Write("Пункт меню: "); c = Convert.ToInt32(Console.ReadLine()); break;
                    case 4: Environment.Exit(0); break;
                }
            }
            Console.ReadKey();// Остановка экрана
        }
        public static void ClearAll()
        {
            Console.WriteLine("Bank account was clear!");
        }
        public static void Menu()
        {
            Console.WriteLine("Меню выбора:");
            Console.WriteLine("1 - Добавить сумму");
            Console.WriteLine("2 - Удалить cумму в очереди");
            Console.WriteLine("3 - Удалить всю сумму");
            Console.WriteLine("4 - Выйти из программы");
        }
    }
}