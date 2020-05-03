using System;

namespace Prog2_Lab6_Cs_Lib
{
    public class Expression
    {
        private double a;
        private double b;
        private double c;
        private double d;

        // Метод для перевірки правильності введених операнд, виконується при введені даних та розрахунку значення виразу.
        private void Check()
        {
            // Перевірка кореня
            if (Double.IsNaN(Math.Sqrt(41 - d))) { throw new ArithmeticException("Квадратний корінь від'ємного числа"); }
            // Перевірка дільника
            else if ((Math.Sqrt(41 - d) - (b * a) + c) == 0) { throw new ArithmeticException("Дільник дорівнює нулю"); }
            return;
        }

        // Метод для розрахунку значення виразу
        public double Calculate()
        { 
            // Викликається перевірка правильності операнд
            Check();
            // Розраховується значення виразу
            return((a * b / 4) - 1) / (Math.Sqrt(41 - d) - (b * a) + c);
        }

        // Конструктор
        public Expression(double aInput, double bInput, double cInput, double dInput)
        {
            a = aInput;
            b = bInput;
            c = cInput;
            d = dInput;

            // Викликається перевірка правильності операнд
            Check();
        }

        // Індексатор для введення-виведення операнд виразу
        // Перевіряє правильність операнд при введенні
        public double this[char index]
        {
            get
            {
                if (index == 'a') { return a; }
                else if (index == 'b') { return b; }
                else if (index == 'c') { return c; }
                else if (index == 'd') { return d; }
                else { throw new ArgumentException("Символ не відповідає жодному з операнд виразу."); }
            }
            set
            {
                if (index == 'a') { a = value; }
                else if (index == 'b') { b = value; }
                else if (index == 'c') { c = value; }
                else if (index == 'd') { d = value; }
                else { throw new ArgumentException("Символ не відповідає жодному з операнд виразу."); }

                // Викликається перевірка правильності операнд
                Check();
            }
        }
    }
}
