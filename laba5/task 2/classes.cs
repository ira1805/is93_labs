using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
	class Figures
	{
		public virtual double S() { return 0; }
		public virtual double P() { return 0; }
	}

	class Rhombus : Figures
	{
		private double x1, y1, x2, y2, x3, y3, x4, y4;

		public Rhombus(params double[][] coord)
		{
			x1 = coord[0][0];
			y1 = coord[0][1];
			x2 = coord[1][0];
			y2 = coord[1][1];
			x3 = coord[2][0];
			y3 = coord[2][1];
			x4 = coord[3][0];
			y4 = coord[3][1];
		}

		public override double S()
		{
			return 0.5 * (Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2))) * (Math.Sqrt(Math.Pow(x4 - x2, 2) + Math.Pow(y4 - y2, 2)));
		}

		public override double P()
		{
			return 4 * (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
		}
	}

	class Circle : Figures
	{
		private double radius;

		public double Radius
		{
			get { return radius; }
		}

		public Circle(double rad)
		{
			radius = rad;
		}

		public override double S()
		{
			return Math.PI * Math.Pow(radius, 2);
		}

		public override double P()
		{
			return 2 * Math.PI * radius;
		}
	}
}