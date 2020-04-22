using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        class Figure
        {
	  public double [,]  coord = new double[2,4];
	public Figure()
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 4; j++)
                        coord[i,j] = 0;
                }
            }
            Figure(double [,] c)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 4; j++)
                        coord[i,j] = c[i,j];
                }
            }
            public double dlinaStoroni()
            {
                return Math.Sqrt(Math.Pow((coord[0,1] - coord[0,0]), 2) + Math.Pow((coord[1,1] - coord[1,0]), 2));
            }
        };


        class Romb : Figure 
{
public Romb() 
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                    coord[i,j] = 0;
            }
        }
        public Romb(double [,] c)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                    coord[i,j] = c[i,j];
            }
        }
        public double ploshad()
        {
            double dd1 = Math.Sqrt(Math.Pow((coord[0,2] - coord[0,0]), 2) + Math.Pow((coord[1,2] - coord[1,0]), 2));
                double dd2 = Math.Sqrt(Math.Pow((coord[0,3] - coord[0,1]), 2) + Math.Pow((coord[1,3] - coord[1,1]), 2));
            return (dd1 * dd2) / 2;
        }
        public double Periment()
        {
            return 4 * dlinaStoroni();
        }
        public void Show()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("[{0},{1}]", coord[0, i], coord[1, i]);
            }
        }
        double get(int i, int j)
        {
            return coord[i,j];
        }
  };

   

static void Main(string[] args)
           {
            double[,] c = new double [2,4];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    c[i, j] = i + j;
                }
            }
        Romb r=new Romb(c);
        r.Show();
Console.WriteLine("Периметр - {0} , площадь - {1}",r.Periment(),r.ploshad());
        }
    }
}
