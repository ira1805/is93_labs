using System;

namespace lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String strdigit = new Digits("145");
            String strcharacters = new Character("abkck");

            Console.WriteLine($" String of digit before adding characters: {strdigit.ToString()}");
            strdigit.AddItem();
            Console.WriteLine($" String of digit after adding characters: {strdigit.ToString()}");
            Console.WriteLine($" String length = {strdigit.GetLength()}");

            Console.WriteLine($" String of characters before adding characters: {strcharacters.ToString()}");
            strcharacters.AddItem();
            Console.WriteLine($" String of characters after adding characters: {strcharacters.ToString()}");
            Console.WriteLine($" String length = {strcharacters.GetLength()}");

            Console.ReadKey();

        }
    }
}
