using System;
using LastSymNamespace;
using CarNamespace;


namespace laba8cs
{
    class Program
    {
        delegate int LastSymbol(string str);
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Мулік Рустам ІС-93\n_______________________________________\n");
            Console.WriteLine("Введіть рядок: ");
            string input = Console.ReadLine();

            var static_delegate = new LastSymbol(LastSymNamespace.LastSymbol.Static);
            Console.WriteLine("\nрезультат статичного методу: " + static_delegate(input));

            LastSymNamespace.LastSymbol example = new LastSymNamespace.LastSymbol();
            LastSymbol example_delegate = example.Example;
            Console.WriteLine("\nрезультат екземплярного методу: " + example_delegate(input) + "\n\n_______________________________________\n");

            Console.WriteLine("1 - дізнатись пробіг\n2 - поїхати\n3 - зупинитись\n4 - придбати нову машину\n5 - придбати б/у машину\nбудь-який інший символ - вихід\n");        
            Car car = new Car();
            car.Checkodo += car.CheckOdometr;

            input = null;
            for (int i = 0; i < 1000; i++)
            {
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("пробіг = " + car.Odometr() + " м");
                }
                else if (input == "2")
                {

                    car.Drive();
                }
                else if (input == "3")
                {
                    car.Stop();
                }
                else if (input == "4")
                {
                    car = new Car();
                    car.Checkodo += car.CheckOdometr;
                }
                else if (input == "5")
                {
                    try
                    {
                        Console.WriteLine("введіть бажаний пробіг");
                        car = new Car(Convert.ToInt32(Console.ReadLine()));
                        car.Checkodo += car.CheckOdometr;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Пробіг може бути лише числом!");
                    }
                    
                }
                else
                {
                    break;
                }
            }
        }
    }
}