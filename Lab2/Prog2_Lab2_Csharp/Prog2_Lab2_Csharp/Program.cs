using System;
using Prog2_Lab2_Lib_Csharp;

namespace Prog2_Lab2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TextSharp textA = new TextSharp(new string[3] { "Hello world", "This is a text", "Hello world" });
            Console.WriteLine("Number of chracters: " + textA.CountAll().ToString());
            Console.WriteLine("Number of 'Hello world's: " + textA.FindCount("Hello world").ToString());
            textA.AddLine(1, "A fresh new line");
            textA.RemoveLine(2);
            textA.FindAndReplaceAll('e', 'x');
            Console.WriteLine(textA);
            textA.CleanAll();
        }
    }
}
