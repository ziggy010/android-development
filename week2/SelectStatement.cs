using System;
namespace C5.week2
{
    public class SelectStatement
    {
        public static void ifElse()
        {
            if (4 > 5)
            {
                Console.WriteLine("5 is greater than 4");
            }
            else if (5 > 4)
            {
                Console.WriteLine("4 is less than 5");
            }
            else
            {
                Console.WriteLine("4 is not equals to 5");
            }

        }

        public static void SwitchCase()
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());



        }
    }
}

