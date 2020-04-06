using System;
using System.Collections.Generic;
using System.Text;

namespace classes
{
	class Line  //клас лінії
	{
		protected int m_x1, m_y1, m_x2, m_y2;   //координати точок
		public Line(int x1, int y1, int x2, int y2) //конструктор з параметрами
		{
			m_x1 = x1;
			m_y1 = y1;
			m_x2 = x2;
			m_y2 = y2;
		}

		public double Length()  //метод знаходження відстані між точками
		{
			return Math.Sqrt(Math.Pow(m_x2 - m_x1, 2) + Math.Pow(m_y2 - m_y1, 2));
		}
	}

	class Section : Line //клас відрізку, є дочірнім класом лінії
	{	
		public Section(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }   //конструктор відрізку з визовом конструктору лінії

		public double AngleOY() //знаходження кута
		{
			return (Math.Acos((m_y2 - m_y1) / Length())) * 180 / 3.1415;
		}

		public string GetFirstCoordinates()	//виведення координат первої точки
		{
			return " x1: " + m_x1.ToString() + "\n y1: " + m_y1.ToString() + "\n\n";
		}

		public string GetSecondCoordinates()	//виведення координат другої точки
		{
			return " x2: " + m_x2.ToString() + "\n y2: " + m_y2.ToString() + "\n\n";
		}
	}
}
