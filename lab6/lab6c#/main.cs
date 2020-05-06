using System;
using System.IO;

namespace LAB6
{
    class Program
    {
        public static void Log(string message)
        {
            File.WriteAllText("Logs.txt", message);
        }

        static void Main(string[] args)
        {
            try
            {
                Expression example1 = new Expression(5, 8, 6, 20);
                //Expression example1 = new Expression(8, 3, 25);
                Console.WriteLine(example1.Сalculating());
            }
            catch (DivideByZeroException exception)
            {
                Log($"Type of exception: {exception.GetType()}, message: {exception.Message}");
            }
            catch (InvalidOperationException exception)
            {
                Log($"Type of exception: {exception.GetType()}, message: {exception.Message}");
            }
            catch (Exception exception)
            {
                Log($"Type of exception: {exception.GetType()}, message: {exception.Message}");
            }
            finally
            {
                Console.WriteLine("Successfully counted");
            }

            Console.ReadKey();
        }
    }
}
