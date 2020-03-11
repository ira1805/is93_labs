//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyText t = new MyText();
            t.Add(new MyString("Baranov Dmytro IS-93"));
            t.Add(new MyString("1. First line"));
            t.Add(new MyString("2. Second line"));

            Console.WriteLine("Baranov Dmytro IS - 93");
            Console.WriteLine("1 to add line");
            Console.WriteLine("2 to remove line");
            Console.WriteLine("3 to replace line");
            Console.WriteLine("4 to clear");
            Console.WriteLine("5 to get line amount");
            Console.WriteLine("6 to get numbers");
            Console.WriteLine();
            Console.WriteLine(t);
            Console.WriteLine();

            int x;
            for (int i = 0; i < 10; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    t.Add(new MyString("3. Added line"));
                    Console.WriteLine(t);
                };  
                if (x == 2)
                {
                    t.RemoveAt(1);
                    Console.WriteLine(t);
                };
                if (x == 3)
                {
                    t.Replace(1, new MyString("line on which was previous line replaced"));
                    Console.WriteLine(t);
                }
                if (x == 4)
                {
                    t.Clear();
                    Console.WriteLine(t);
                }
                if (x == 5)
                    Console.WriteLine(t.Size() + "\n");
                if (x == 6)
                    Console.WriteLine(t.GiveMeAllTheFuckingSymbolsYouSeeInHere() + "\n");
            }
        }
    }
}
