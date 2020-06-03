using System;
using System.Collections.Generic;
using System.Text;

namespace vector
{
    class MyVector
    {
        private double len;
        private double ang;

        public MyVector()     //конструктор за змовчуванням
        {
            len = 0;
            ang = 0;
        }

        public MyVector(double len, double ang)    //конструктор з параметрами
        {
            this.len = len;
            this.ang = ang;
        }

        public MyVector(MyVector input) //конструктор копіювання
        {
            len = input.len;
            ang = input.ang;
        }

        public void Povorot(double ang)   //метод повороту на заданий кут
        {
            this.ang += ang;
        }

        public double Length //метод отримання довжини
        {
            get
            {
                return len;
            }
            
        }

        public double Angle //метод отримання кута
        {
            get
            {
                return ang;
            }
            
        }

        public static MyVector operator*(MyVector z, double x)    //перевантаження оператора множення
        {
            return new MyVector(z.len * x, z.ang);
        }

        public static MyVector operator+(MyVector z1, MyVector z2) //перевантаження оператора додавання
        {
            return new MyVector(z1.len + z2.len, z1.ang + z2.ang);
        }

        public override string ToString() //перевантаження методу виведення
        {
            return "довжина = " + len.ToString() + "\nкут = " + ang.ToString() + "°\n";
        }
    }
}