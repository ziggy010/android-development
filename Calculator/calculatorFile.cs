using System;
namespace C5.Calculator
{
    public class calculatorFile
    {
        public static void initialize()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose any number to start the calculation: ");
            Console.WriteLine("Enter 1 for addition");
            Console.WriteLine("Enter 2 for subtraction");
            Console.WriteLine("Enter 3 for multiplication");
            Console.WriteLine("Enter 4 for division");

            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Addition(firstNumber, secondNumber);
                    break;
                case 2:
                    Subtraction(firstNumber, secondNumber);
                    break;
                case 3:
                    Multiplication(firstNumber, secondNumber);
                    break;
                case 4:
                    division(firstNumber, secondNumber);
                    break;

                default:
                    Console.WriteLine("madarchod");
                    break;
            }
        }

        

        


        public static void Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"The addition of {firstNumber} and {secondNumber} is: {firstNumber + secondNumber}");
        }

        public static void Subtraction(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"The subtraction of {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
        }

        public static void Multiplication(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"The multiplication of {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
        }

        public static void division(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"The division of {firstNumber} and {secondNumber} is {firstNumber / secondNumber}");
        }
    }
}

