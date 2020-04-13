using System;
using Classes_;

namespace laba5__oop_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baranov Dmytro IS-93");
            Uppercas up = new Uppercas("UPPERCASE");
            Lowercase low = new Lowercase("lowercase");
            Console.WriteLine("\n\nclass Uppercase:\n\n data:  'UPPERCASE'\n\n lenght:  " + up.Length() + "\n");
            up.Sort();
            Console.WriteLine("\n\nclass Lowercase:\n\n data:  'lowercase'\n\n lenght:  " + low.Length() + "\n");
            low.Sort();
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
    }
}
