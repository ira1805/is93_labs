using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Figures//Basic class
    {
        protected double x1,y1, x2,y2, x3,y3, x4,y4;//координаты
        public double side_1, side_2, side_3, side_4;//стороны
        public Figures(double x1, double y1, double x2, double y2, double x3, double y3,double x4, double y4)//конструктор с параметрами
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
            Length();
        }
        private void Length()// Method для изчисления длин сторон
        {
            side_1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));//Calculation side 1
            side_2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));//Calculation side 2
            side_3 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));//Calculation side 3
            side_4 = Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2));//Calculation side 4
        }
    }
    public class Rectangle:Figures//Наследуемый класс
    {
        private double perimetr = 0;//Perimeter
        private double ploscha = 0;//Area
        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4):base(x1, y1, x2, y2, x3, y3, x4, y4)//Designer with parametrs
        {
            Perimetr(side_1,side_2);
            Ploscha(side_1,side_2);
        }
        private void Perimetr(double a, double b)//Method for Calculation perimetr
        {
            perimetr = (a + b) * 2.0;
        }
        private void Ploscha(double a, double b)//methid for calculation area
        {
            ploscha = a * b;
        }
        public double GetPerimetr()// Method for getting perimetr
        {
            return perimetr;
        }
        public double GetPloscha()// Method for getting area
        {
            return ploscha;
        }
    }
}
