using System;
namespace C5.week3
{
    public class odd_even
    {
        public static void numbers()
        {
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("The given number is even.");
            }
            else
            {
                Console.WriteLine("The given number is odd.");
            }
        }
    }
}

