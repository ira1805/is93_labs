using System;
using Classes;

namespace laba5cspoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Мулік Рустам ІС-93\n_______________________________________\n");
            double[] A = { 6, 3 };
            double[] B = { 9, 4 };
            double[] C = { 10, 7 };
            double[] D = { 7, 6 };
            Rhombus romb = new Rhombus(A, B, C, D);
            Circle krug = new Circle(5);
            Console.WriteLine("Координати вершин ромба:");
            Console.WriteLine("A(" + $"{A[0]}, {A[1]}" + ")");
            Console.WriteLine("B(" + $"{B[0]}, {B[1]}" + ")");
            Console.WriteLine("C(" + $"{C[0]}, {C[1]}" + ")");
            Console.WriteLine("D(" + $"{D[0]}, {D[1]}" + ")");
            Console.WriteLine("Радіус кола = " + krug.Radius + "\n");

            Console.WriteLine("Площа ромба = " + romb.S().ToString("F3") + "\n");
            Console.WriteLine("Периметр ромба = " + romb.P().ToString("F3") + "\n");
            
            Console.WriteLine("Площа круга = " + krug.S().ToString("F3") + "\n");
            Console.WriteLine("Довжина кола = " + krug.P().ToString("F3") + "\n");
            Console.ReadKey();
        }
    }
}