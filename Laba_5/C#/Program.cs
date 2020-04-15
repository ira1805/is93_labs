using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Figure;

namespace Laba_5
{
    class Program
    {
        static void Main()
        {
            double x1, y1, x2, y2, x3, y3, x4, y4;
            Console.WriteLine("First coordinates:");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second coordinates: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Third coordinates: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fourth coordinates: ");
            x4 = Convert.ToDouble(Console.ReadLine());
            y4 = Convert.ToDouble(Console.ReadLine());
            Trapeze example = new Trapeze(x1, y1, x2, y2, x3, y3, x4, y4);
            Console.WriteLine("Perimetr: " + example.Get_Perimetr().ToString());//Perimetr
            Console.WriteLine("Square: " + example.Get_Square().ToString());//Square
            Console.ReadKey();
        }
    }
}