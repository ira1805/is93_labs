using System;
using vector;

namespace laba4cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MyVector z1 = new MyVector();   // використання конструктора за змовчуванням
            MyVector z2 = new MyVector(7.5, 60);   // використання конструктора з параметрами
            MyVector z3 = new MyVector(z2);   // використання конструктора копіювання
            Console.WriteLine("Мулік Рустам ІС-93\n_______________________________________\n");

            Console.WriteLine("Z1() - використання конструктора за змовчуванням\n" + z1);
            Console.WriteLine("Z2(7.5, 60) - використання конструктора з параметрами\n" + z2);
            Console.WriteLine("Z3(Z2) - використання конструктора копіювання\n" + z3);
            Console.WriteLine("збільшення у 2 рази довжини об’єкта Z3");
            z3 = z3 * 2;
            Console.WriteLine(z3);
            Console.WriteLine("поворот Z3 на 90°");
            z3.Povorot(90);
            Console.WriteLine(z3);
            Console.WriteLine("Z1 = Z2 + Z3");
            z1 = z2 + z3;
            Console.WriteLine(z1 + "\n\nВектор Z1\nДовжина: " + z1.Length + "\nКут: " + z1.Angle);

            Console.ReadKey();
        }
    }
}