using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Figures//Базовий клас
    {
        protected double x1, x2, x3, x4, y1, y2, y3, y4;//координаты
        public double Line_1, Line_2, Line_3, Line_4;//стороны
        public Figures(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)//конструктор с параметрами
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
            Length();
        }
        private void Length()// For length
        {
            Line_1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));//Line a
            Line_2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));//Line b
            Line_3 = Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2));//Line c
            Line_4 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));//Line d
        }
    }
    public class Trapeze : Figures//Похідний класс
    {
        private double perimetr = 0;//Perimeter
        private double square = 0;//Square
        public Trapeze(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)//Designer with parametrs
        {
            Perimetr(Line_1, Line_2,Line_3,Line_4);
            Square(Line_1, Line_2,Line_3, Line_4);
        }
        private void Perimetr(double a, double b, double c, double d)//Method Perimetr
        {
            perimetr = a + b + c + d;
        }
        private void Square(double a, double b,double c,double d)//Method Square
        {
            square = ((a+b)/2)*Math.Sqrt(Math.Pow(c,2)-(Math.Pow(a-b,2)+ Math.Pow(c,2)-Math.Pow(d, 2)/(2*(a-b))));//Arifmetic
        }
        public double Get_Perimetr()// Method for Getting perimetr
        {
            return perimetr;
        }
        public double Get_Square()//Method for Getting square
        {
            return square;
        }
    }
}