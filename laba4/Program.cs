using System;
using vector;

namespace laba4_oop_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baranov Dmytro IS-93\n\n");
            VectorPol v1 = new VectorPol();
            VectorPol v2 = new VectorPol(5, 30);
            VectorPol v3 = new VectorPol(v2);
            Console.WriteLine("v1()\n" + v1 + "\nv2(5, 30)\n" + v2 + "\nv3(v2)\n" + v3 + "\n" + "v2 / 2");
            v2 = v2 / 2;
            Console.WriteLine(v2 + "\nrotate v3 on 45deg");
            v3.Rotate(45);
            Console.WriteLine(v3 + "\nv2 + v3");
            v2 = v2 + v3;
            v1 = v2;
            Console.WriteLine(v2 + "\nv1: result\nradius: " + v1.GetRad() + "\n angle: " + v1.GetAng());

            Console.ReadKey();
        }
    }
}
