using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresLibrary;

namespace Лабораторна_робота__5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Samilenko Oleksandr IS-93");
            double x1, y1, x2, y2, x3, y3, x4, y4;
            Console.WriteLine("Введите координаты для прямоугольника(Обход фигуры делать за или против часовой стрелки!):");
            Console.WriteLine("Введите координаты 1-й вершины(в 2-х мерном пространстве):");
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты 2-й вершины(в 2-х мерном пространстве):");
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты 3-й вершины(в 2-х мерном пространстве):");
            Console.Write("x3 = ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3 = ");
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты 4-й вершины(в 2-х мерном пространстве):");
            Console.Write("x4 = ");
            x4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y4 = ");
            y4 = Convert.ToDouble(Console.ReadLine());
            Rectangle value = new Rectangle(x1,y1,x2,y2,x3,y3,x4,y4);//Make example class of Rectangle
            Console.WriteLine("Перuметр прямоугольника = "+value.GetPerimetr().ToString());//Output perimetr
            Console.WriteLine("Площадь прямоугольника = "+value.GetPloscha().ToString());//Output area
            Console.ReadKey();
        }
    }
}
