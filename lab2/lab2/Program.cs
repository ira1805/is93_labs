using lab2_Entities;
using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = new MyString(new char[] { 's', 't', 'r', ' ' });              //string1
            var string2 = new MyString(new char[] { 's', 't', 'r', '1', '2' });         //string2
            var string3 = new MyString(new char[] { 's', 't', 'r', '1', '2', '3' });    //string3

            var text = new MyText(new MyString[] { string1, string2, string3 });        //text

            Console.WriteLine("Array before changes ");
            text.Print();
            Console.WriteLine("Array after adding 1 string");
            text.AddingString(string2);                                               //method for adding1 string
            text.Print();
            Console.WriteLine($"Shortest string length: {text.GetShortestStringLength()}"); //method for count length of shortest string
            Console.WriteLine($"Percant of constonant letters: {text.GetConsonantLettersPercentage()}%");//method for get recantage of consonant letters
            text.DeleteWhiteSpaces();                                               //method for delete whitespaces
            Console.WriteLine("Array afetr deleted whitespaces");
            text.Print();
            Console.WriteLine("Enter number of string which must delete");
            int index = Int32.Parse(Console.ReadLine());
            text.DeleteString(index);                                               //method for delete string
            text.Print();
            text.CleaneArrray();                                                    //method for delete array
        }
    }
}

  