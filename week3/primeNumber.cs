using System;
namespace C5.week3
{
    public class primeNumber
    {

        public static void forPrime()
        {
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    b++;
                }
            }

            if (b == 2)
            {
                Console.WriteLine($"The given number {a} is prime.");
            }
            else
            {
                Console.WriteLine("The given number is not prime.");
            }
            Console.ReadLine();
        }
    }
}

