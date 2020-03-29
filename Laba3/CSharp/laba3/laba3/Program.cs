using System;

namespace laba3
{
    class Program
    {
        static double[,] matrixA()
        {
            double[,] a = {
                { 5.68, 1.12, 0.95, 1.32, 0.83 },
                { 1.12, 3.78, 2.12, 0.57, 0.91 },
                { 0.95, 2.12, 6.63, 1.29, 1.57 },
                { 1.32, 0.57, 1.29, 4.07, 1.25 }, 
                { 0.83, 0.91, 1.57, 1.25, 5.71 }
            };
            return a;
        }

        static double[] matrixB()
        {
            double[] b = { 6.365, 3.21, 4.105,  6.25, 5.125 };
            return b;
        }

        static int Main()
        {
            double[,] a = matrixA();
            double[] b = matrixB();
            int n = 5;
            double e = 0.000001;
            double[] x = new double[n];

            for (int i = 0; i < n; i++)
            {
                x[i] = 0;
            }

            calc(x, e, n, a, b);
            Console.ReadKey(); 

            return 0;
        }

        static void calc(double[] x, double e, int n, double[,] A, double[] b)
        {
            double[] xx = new double[n];
            double z = 0, p = 0;
            Console.WriteLine("\nMethod of Zeydel: \n");

            do
            {
                for(int i = 0; i < n; i++)
                {
                    xx[i] = x[i];
                }
                x[0] = (6.365 - 1.12 * x[1] - 0.95 * x[2] - 1.32 * x[3] - 0.83 * x[4]) / 5.68;
                x[1] = (3.21 - 1.12 * x[0] - 2.12 * x[2] - 0.57 * x[3] - 0.91 * x[4]) / 3.78;
                x[2] = (4.105 - 0.95 * x[0] - 2.12 * x[1] - 1.29 * x[3] - 1.57 * x[4]) / 6.63;
                x[3] = (6.25 - 1.32 * x[0] - 0.57 * x[1] - 1.29 * x[2] - 1.25 * x[4]) / 4.07;
                x[4] = (5.125 - 0.83 * x[0] - 0.91 * x[1] - 1.57 * x[2] - 1.25 * x[3]) / 5.71;

                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0,10}", x[i].ToString("0.0000000"));
                }
                Console.WriteLine();
                p++;
                for (int i = 0; i < n; i++)
                {
                    if (Math.Abs(x[i] - xx[i]) < e)
                    {
                        z++;
                    }
                }
            } while (z < 1);
            Console.WriteLine("Number of iterations: {0}\n", p);
            Console.WriteLine("Roots of the equation: \n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(x[i].ToString("0.000000"));
            }
            Console.WriteLine("\nDelta is: \n");
            double[] r = new double[5];
            double[] a1 = new double[5];
            for (int i = 0; i < n; i++)
            {
                a1[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    a1[i] += A[i,j] * x[j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                r[i] = b[i] - a1[i];
                Console.WriteLine(r[i].ToString("0.000000"));
            }
        }

    }
}