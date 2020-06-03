using System;

namespace laba7cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Мулік Рустам ІС-93\n_______________________________________\n");
            short[] arr = {5, 3, 8, 6, 38, 60, 49, 1 };
            LinkedList list = new LinkedList();
            list.InitList(arr);
            Console.WriteLine("список: " + list.OutputList());
            Console.WriteLine("\nкількість елементів, кратних 7: " + list.Divaded(7));
            list.MoreThanMiddle();
            Console.WriteLine("\nсписок після заміни елементів більших за середнє значення на 0:\n" + list.OutputList());
        }
    }
}
