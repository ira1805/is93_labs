using System;

namespace Prog2_Lab5_1_Cs_Lib
{
    public class Figure
    {
        protected int[,] points;

        public int[,] Get()
        {
            return points;
        }
        public int Get(int i1, int i2)
        {
            return points[i1, i2];
        }

        // Конструктор з памаметром
        public Figure(int[,] input)
        {
            points = input;
        }

        // Метод для розрахунку відстані між вершинами
        public float Length(int i1, int i2)
        {
            if (i1 == -1) { i1 = 3; }
            int[] a = { points[i1, 0], points[i1, 1] };
            int[] b = { points[i2, 0], points[i2, 1] };
            return Convert.ToSingle(Math.Sqrt(Math.Pow((a[0] - b[0]), 2) + Math.Pow((a[1] - b[1]), 2)));
        }

        // Пустий конструктор для використання підкласами з власними конструкторами
        // protected залишає доступ похідним классам без повного відкриття команди
        protected Figure()
        {
        }
    }

    public class Square : Figure
    {
        // Конструктор з памаметром
        public Square(int[,] input)
        {
            points = new int[4, 2];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    points[i, j] = input[i, j];
                }
            }
        }

        // Метод для розрахунку периметра квадрату
        // Використовує метод визначення відстані з базового класу
        public float Perimeter()
        {
            float peri = 0;
            for (int i = 0; i < 4; i++)
            {
                peri += Length(i - 1, i);
            }
            return peri;
        }

        // Метод для розрахунку площі квадрату
        // Використовує метод визначення відстані з базового класу
        public float Area()
        {
            return (Length(0, 1) * Length(1, 2));
        }
    }
}
