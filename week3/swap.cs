using System;
namespace C5.week3
{
    public class swap
    {
        public static void swapNum()
        {
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"first number a = {a} and second number b = {b}");

            int c = a;

            a = b;
            b = c;

            Console.WriteLine($"so swapping, a = {a} and b = {b}");

            Console.ReadKey();

        }
    }
}

