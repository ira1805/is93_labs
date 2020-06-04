using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Q1 = new Rectangle();                         //default constructor 
            Rectangle Q2 = new Rectangle(2, 2, 2, 6, 8, 6, 2, 8);   //constructor with parametrs
            Rectangle Q3 = new Rectangle(Q2);                       //constructor with copy

            Q2 /= 2;
            Console.WriteLine($"Q2 = {Q2}");

            Console.WriteLine($"Q1 = {Q1}");
            Q1 = Q3 - Q2;
            Console.WriteLine($"new Q1 = {Q1}");

            Console.WriteLine($"Perimetrium for rectangle Q1= {Q1.CalculatePerimetrium()} ");
            Console.WriteLine($"Square for rectangle Q2 = {Q2.CalculateSquare()}");
            Console.ReadKey();
        }
    }
}
