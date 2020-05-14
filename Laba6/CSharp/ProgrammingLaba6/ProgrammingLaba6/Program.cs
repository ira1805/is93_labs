using System;
using System.IO;
using System.Text;

namespace ProgrammingLaba6
{

    class Expression
    {
        double a;
        double b;
        double c;

        public Expression(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double Result() {
            return dividing((8 * log10(b - 1) - c), (a * 2 + dividing(b, c)));
        }

        public double log10(double a) {
            double res = 0;
            try {
                if (a <= 0)
                    throw new Exception("log10 Error");
                res = Math.Log10(a);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                using (StreamWriter logExp = new StreamWriter(@"log.txt", true, System.Text.Encoding.Default)) {
                    logExp.WriteLine(e.Message + " " + Convert.ToString(DateTime.Now));
                }
            }
            return res;
        }

        private double dividing(double a, double b) {
            double res = 0;

            try {
                if (b == 0)
                    throw new Exception("dividing by zero");
                res = a / b;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                using (StreamWriter logExp = new StreamWriter(@"log.txt", true, System.Text.Encoding.Default)) {
                    logExp.WriteLine(e.Message + " " + Convert.ToString(DateTime.Now));
                }
            }
            return res;
        }

        public static double operator /(Expression a, double b) {
            double res = 0;

            try {
                if (b == 0)
                    throw new Exception("dividing by zero (operator)");
                res = a.a / b;
            } catch (Exception e) {
                Console.WriteLine(e.Message + " " + Convert.ToString(DateTime.Now));
                using (StreamWriter logExp = new StreamWriter(@"log.txt", true, System.Text.Encoding.Default)) {
                    logExp.WriteLine(e.Message + " " + Convert.ToString(DateTime.Now));
                }
            }
            return res;
        }

    }

    class Program {

        static void Main(string[] args) {

            Expression[] a = { new Expression(1, 1, 1), new Expression(1, 2, 0), new Expression(1, 1, 0) };

            Console.WriteLine("a[0].Result() = {0} \n", a[0].Result());
            Console.WriteLine("a[1].Result() = {0} \n", a[1].Result());
            Console.WriteLine("a[2].Result() = {0} \n", a[2].Result());

            double d = a[0] / 0;
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}