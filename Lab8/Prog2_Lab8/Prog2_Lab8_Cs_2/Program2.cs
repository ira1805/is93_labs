using System;
using Prog2_Lab8_Cs_Lib;

namespace Prog2_Lab8_Cs_2
{
    class Program2
    {
        // Метод-обробник події
        static void EventHandler(object sender)
        {
            Console.WriteLine("Перевищення трафiку в iнтернет-сервiсi " + ((Internet_Service)sender).name + ".");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Стеблянко Олександр, Лабораторна 8, Завдання 9 \n");

            Internet_Service IS = new Internet_Service("Тест-Сервiс");
            // Підписка обробника до делегату
            IS.Traffic_Exceeded += new Internet_Service.IS_Event(EventHandler);
            IS.On_Traffic_Exceeded();

            // Відписка обробника від делегату
            Console.WriteLine("\nВiдписуємо обробник");
            IS.Traffic_Exceeded -= new Internet_Service.IS_Event(EventHandler);
            IS.On_Traffic_Exceeded();
        }
    }
}
