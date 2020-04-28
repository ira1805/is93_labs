using System;

namespace Prog2_Lab4_Lib
{
    public class Triangle
    {
        // Точки трикутника - двомірний масив
        // 3 точки, 2 виміри
        private int[, ] points = new int[3, 2];

        // Метод отримання даних (точок) трикутника
        public int[,] Get()
        {
            return points;
        }

        // Перевантажений метод отримання даних трикутника, повертає одне значення матриці точок
        // Використовується в функції виведення значень на екран, в основній програмі
        public int Get(int i1, int i2)
        {
            return points[i1, i2];
        }

        // Конструктор за умовченням
        public Triangle()
        {
            points = new int[3, 2] { { 1, 0}, { 0, 1}, { 0, 0} };
        }

        // Конструктор з памаметром
        public Triangle(int[,] input)
        {
            if (input.GetLength(0) != 3 | input.GetLength(1) != 2) { throw new ArgumentException("Вхідний масив іншого розміру ніж 3 на 2"); }
            points = input;

            if ((points[0, 0]*points[1, 1] == points[0, 1] * points[1, 0]) && (points[0, 0] * points[2, 1] == points[0, 1] * points[2, 0])) 
                    { throw new ArgumentException("Точки трикутника знаходяться на одній прямій"); }
        }

        // Конструктор копіювання
        public Triangle(Triangle input)
        {
            points = input.Get();
        }

        // Метод обчислення відстанні між точками трикутника
        // Приватний метод, використовується для розрахунку периметра
        private float Length(int i1, int i2) {
            if (i1 == -1) { i1 = 2; }
            int[] a = { points[i1, 0], points[i1, 1] };
            int[] b = { points[i2, 0], points[i2, 1] };
            return Convert.ToSingle(Math.Sqrt(Math.Pow((a[0] - b[0]), 2) + Math.Pow((a[1] - b[1]), 2)));
        }

        // Метод обчислення периметра
        public float Perimeter()
        {
            float peri = 0;
            for (int i = 0; i < 3; i++)
            {
                peri += Length(i - 1, i);
            }
            return peri;
        }

        // Метод обчислення площі
        public float Area()
        {
            return (Convert.ToSingle(Math.Abs(points[0, 0] * (points[1, 1] - points[2, 1])) + Math.Abs(points[1, 0] * (points[2, 1] - points[0, 1])) + Math.Abs(points[2, 0] * (points[0, 1] - points[1, 1])) ) / 2);
        }

        // Переватнаження оператору додавання
        // Додає координати відпоівдних точок двох трикутників
        public static Triangle operator +(Triangle aTri, Triangle bTri)
        {
            int[, ] result = new int[3, 2];

            int[,] a = aTri.Get();
            int[,] b = bTri.Get();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return new Triangle(result);
        }

        // Переватнаження оператору множення
        // Множить всі координати трикутника на дане число
        public static Triangle operator *(Triangle aTri, int b)
        {
            int[,] result = new int[3, 2];

            int[,] a = aTri.Get();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = a[i, j] * b;
                }
            }
            return new Triangle(result);
        }
    }
}
