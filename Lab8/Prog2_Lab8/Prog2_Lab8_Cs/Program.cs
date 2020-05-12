using System;
using Prog2_Lab8_Cs_Lib;

namespace Prog2_Lab8_Cs
{
    class Program
    {
        // Делегат екземплярного методу
        public delegate bool Inst_Comp(int i);

        // Делегат статичного методу
        public delegate bool Stat_Comp(int[] A, int[] B, int i);

        static void Main(string[] args)
        {
            Console.WriteLine("Стеблянко Олександр, Лабораторна 8, Завдання 9 \n");

            int[] A = { 4, 6, 8, 1 };
            int[] B = { 2, 9, 8, 2, 5 };

            // Включення статичного методу класу в делегат
            Stat_Comp static_comp = Two_Matrices.static_matrix_comparitor;

            //  Включення статичного методу обєкта класу в делегат
            Two_Matrices test = new Two_Matrices(A, B);
            Inst_Comp instance_comp = test.instance_matrix_comparitor;

            // Виклик делешатів
            Console.WriteLine("Делегат статичного методу: " + static_comp(A, B, 2).ToString());
            Console.WriteLine("Делегат екземплярного методу: " + instance_comp(2).ToString());
        }
    }
}
