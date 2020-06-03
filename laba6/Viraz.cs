using System;
using System.Collections.Generic;
using System.Text;

namespace viraz
{
    class Viraz
    {
        private double a, b, c, result;

        public Viraz()
        {
             a = b = c = 0;
        }

        public Viraz(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double[] abc
        {
            set
            {      
                 a = value[0];
                 b = value[1];
                 c = value[2];
            }
        }

        public void SetVars(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string Calculator()
        {
            try
            {
                if ((b / c == 42) || (c == 0))
                    throw new Exception("помилка ділення на 0");
                else if (a * b <= -2)
                    throw new Exception("підлогарифмічний вираз може бути лише додатнім");
                else
                {
                    result = (Math.Log(a * b + 2) * c) / (41 - b / c + 1);
                    return "виконано!\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public string Result()
        {
            if (result != 0)
                return result.ToString();
            else
                return "помилка";
        }
    }
}