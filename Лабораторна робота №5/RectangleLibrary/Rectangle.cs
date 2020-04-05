using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresLibrary;

namespace RectangleLibrary
{
    public class Rectangle
    {
        private double perimetr=0;
        private double ploscha=0;
        protected Figures object1;
        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            object1 = new Figures(x1, y1, x2, y2, x3, y3, x4, y4);
            Perimetr(object1.side_1, object1.side_2);
            Ploscha(object1.side_1, object1.side_2);
        }
        private void Perimetr(double a,double b)
        {
            perimetr = (a + b) * 2.0;
        }
        private void Ploscha(double a, double b)
        {
            ploscha = a * b;
        }
        public double GetPerimetr()
        {
            return perimetr;
        }
        public double GetPloscha()
        {
            return ploscha;
        }
    }
}
