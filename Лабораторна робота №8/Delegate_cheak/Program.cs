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
            Console.WriteLine("Samilenko Oleksandr IS-93");
            Console.Write("string = ");
            string s = Console.ReadLine();
            Cheak val = new Cheak();
            DelegeteClass del;
            del = Cheak.FindL;//Add new delegat
            Console.Write("For static mathod: ");
            if(del(s)==true)
            {
                Console.WriteLine("String has a litteral!!!");
            }
            else
            {
                Console.WriteLine("String has not a litteral!!!");
            }

            Console.Write("For examples of class: ");
            del = val.FindL2;//Add new delegate
            if (del(s) == true)
            {
                Console.WriteLine("String has a litteral!!!");
            }
            else
            {
                Console.WriteLine("String has not a litteral!!!");
            }
            Console.WriteLine("Second exercise!");
            DelegateClear deleg = ClearAll;//Add new method to delegat, with send to class
            int c;
            Console.WriteLine("Вы будите подписыватся на рассылку(+ или -)?: ");
            char cr = Convert.ToChar(Console.ReadLine());
            Class1 value;
            if (cr == '+')
            {
                value = new Class1(deleg);//Add new object of Class1 is class
            }
            else
            {
                value = new Class1();//Add new object of Class1 is class
            }
            Menu();
            Console.WriteLine("Выберите пункт меню:");
            c = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (c)
                {
                    case 1: Console.WriteLine("Введите новый элемент: "); object obj = Console.ReadLine(); value.AddNewElement(obj); Menu(); Console.Write("Пункт меню: "); c = Convert.ToInt32(Console.ReadLine()); break;
                    case 2: value.DeleteElement(); Menu(); Console.Write("Пункт меню: "); c = Convert.ToInt32(Console.ReadLine()); break;
                    case 3: value.RemoveAll(); Menu(); Console.Write("Пункт меню: "); c = Convert.ToInt32(Console.ReadLine()); break;
                    case 4: Environment.Exit(0); break;
                }
            }
            Console.ReadKey();// Stoping of a screen!
        }
        public static void ClearAll()
        {
            Console.WriteLine("Line was clear!!!");
        }
        public static void Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Добавить элемент!");
            Console.WriteLine("2. Удалить элемент в очереди");
            Console.WriteLine("3. Удалить все!");
            Console.WriteLine("4. Выйти из программы");
        }
    }
}
