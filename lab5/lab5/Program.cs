using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Trapeze1 = new Trapeze(0, 1, 3, 3, 5, 3, 7, 0);

            Console.WriteLine($"Trapeze1 = {Trapeze1}");
            Console.WriteLine($"Perimeter for Trapeze1 = {Trapeze1.FindPerimetr()}");
            Console.WriteLine($"Square for Trapeze1 = {Trapeze1.FindSquare()}");

            Console.ReadKey();
        }
    }
}
