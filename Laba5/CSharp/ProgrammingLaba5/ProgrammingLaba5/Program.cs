using System;

namespace ProgrammingLaba5
{
    //MARK: 1 Task
    class Raw
    {

        public Raw() { }
        public Raw(string raw)
        {
            this.raw = raw;
        }

        public int length()
        {
            return raw.Length;
        }

        public void printRaw()
        {
            Console.WriteLine(raw);
        }

        protected string raw = "";
    };

    class NumberRaws : Raw {
        public NumberRaws() { }
        public NumberRaws(string numbersRaw)
        {
            this.raw = numbersRaw;
        }

        public void removeSymbol(char symbol)
        {
            raw = raw.Trim(symbol);
        }
    };

    //MARK: 2 Task

    abstract class Figura
    {
        public Figura() { }
        protected virtual double perimeter()
        {
        }

        protected virtual double square()
        {
        }
    };

    class Trapeze : Figura
    {
        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double d = 0;
        public double height = 0;

        public Trapeze() { }
        public Trapeze(double a, double b, double c, double d, double height)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.height = height;
        }

        public virtual double perimeter()
        {
            return a + b + c + d;
        }

        public virtual double square()
        {
            return (a + b) / 2 * height;
        }
    };

    class Circle : Figura
    {
        public double radius = 0;
        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public virtual double perimeter()
        {
            return 2 * 3.14 * radius;
        }

        public virtual double square()
        {
            return 3.14 * radius * radius;
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shershun Maksim IS-93");
            Console.WriteLine();

            //MARK: 1 Task

            Console.WriteLine("1 Task");
            NumberRaws numbers = new NumberRaws("123456789987654321");
            numbers.printRaw();
            Console.WriteLine($"Current length of raw is {numbers.length()}");
            numbers.removeSymbol('1');
            numbers.printRaw();
            Console.WriteLine($"Length of raw after removing 1 symbols is {numbers.length()}");
            Console.WriteLine();
            Console.WriteLine();


            //MARK: 2 Task
            Console.WriteLine("2 Task");

            Trapeze trapeze = new Trapeze(5.6, 8.4, 6.6, 5.2, 4);
            Console.WriteLine($"Trapeze perimeter is {trapeze.perimeter()}");
            Console.WriteLine($"Trapeze square is {trapeze.square()}");

            Circle circle = new Circle(5.5);
            Console.WriteLine($"Circle perimeter is {circle.perimeter()}");
            Console.WriteLine($"Circle square is {circle.square()}");

    }
    }
}
