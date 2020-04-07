using System;
using System.Collections.Generic;

namespace ProgramingLaba4
{

    class Raw
    {

        public List<string> raws;

        public Raw() { }//Default Constructor

        public Raw(List<string> text)
        { // Constructor with parametrs
            this.raws = text;
        }

        public Raw(Raw input)
        { // Copy Constructor
            this.raws = input.raws;
        }

        public int getLength()
        {
            int length = 0;

            for (int i = 0; i < raws.Count; i++)
                length += raws[i].Length;

            return length;
        }

        List<string> getRaws()
        {
            return raws;
        }

        public static Raw operator +(Raw left_val, Raw right_val)
        {
            Raw result = left_val;

            for (int i = 0; i < right_val.getLength(); i++)
                result.raws.Add(right_val.raws[i]);

            return result;
        }

        public static Raw operator -(Raw value, char symbol)
        {
            Raw result = new Raw();

            for (int i = 0; i < value.raws.Count; i++)
                value.raws[i].TrimEnd(symbol);


            result = value;

            return result;
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IS-93 Shershun Maksim, 13 variant");

            string input = "";
            int rawsAmount = 0;

            List<string> raws = new List<string>();
            Console.Write("Enter amount of raws: ");
            input = Console.ReadLine();

            for (int j = 0; j < int.Parse(input); j++)
            {
                string raw;
                raw = Console.ReadLine();
                raws.Add(raw);
            }

            Raw CS1;
            Raw CS2 = new Raw(raws);
            Raw CS3 = new Raw(CS2);

            Console.WriteLine("Length of CS2 = " + CS2.getLength());

            CS2 = CS2 - '1';
            Console.WriteLine("CS2 after minus operation");
            foreach (string raw in CS2.raws)
            {
                Console.Write(raw + " ");
            }

            Console.WriteLine();

            CS1 = CS2 + CS3;
            Console.WriteLine("CS1 after plus operation");
            foreach (string raw in CS1.raws)
            {
                Console.Write(raw + " ");
            }
        }
    }
}
