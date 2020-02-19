using System;
   
   class program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть цифру для зменшення: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Zmenshenya(ref number1);
            Console.WriteLine("Цифра після зменшення = " + number1.ToString());
            Console.WriteLine();

            Console.Write("Введіть першу цифру для порівняння: ");
            int number_1 = Convert.ToInt32(Console.ReadLine());
			      Console.Write("Введіть другу цифру для порівняння: ");
		      	int number_2 = Convert.ToInt32(Console.ReadLine());

            if (Porivnianya(number_1, number_2) == true)
                Console.WriteLine("Перша цифра більше 2 цифри");
            else
                Console.WriteLine( "Перша цифра не більше другої цифри");
                Console.ReadKey();
        }
static void Zmenshenya(ref int num)
{
int num_i;
if(num == 0)
num = -1;
else if (num != 0)
   for (int temp = 0; temp < sizeof(int) * 8 - 1; temp++)
      {
        num_i = num & (1 << temp);
       if (num_i > 0)
                {
                  for (int i = 0; i < temp + 1; i++)
                  num = num ^ (1 << i);
                  break;
                 }
      }

}
static bool Porivnianya(int number_1, int number_2)
		  {
      bool flag = false;
      int a, b;
      for (int temp = sizeof(int) * 8 - 1; temp >= 0; temp--)
            {
                a = number_1 & (1 << temp);
                b = number_2 & (1 << temp);
                if (a < b)
                {
                    flag = false;
                    break;
                }
                else if (a > b)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
