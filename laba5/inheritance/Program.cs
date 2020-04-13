using System;
using classes;

namespace laba5_oop_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Section s = new Section(0, 0, 3, 4);
            Console.WriteLine("Baranov Dmytro IS-93\n\ncoordinates:\n" + s.GetFirstCoordinates() + s.GetSecondCoordinates() +
                              "length: " + s.Length() + "\n\nthe angle with OY axis: " + s.AngleOY() + "\n\n");
            Console.ReadKey();
        }
    }
}
