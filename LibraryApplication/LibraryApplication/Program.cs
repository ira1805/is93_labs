using Library;
using System;

namespace LibraryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new LibraryManager();       //instance of LibraryManager class
            x.ShowMainMenu();                   //method with main logic of program
            x.SaveData();                       //method that save data to files
            Console.ReadKey();
        }
    }
}