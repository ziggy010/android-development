using System;
namespace C5.week4
{
    public class callingAbstract : abstract_class
    {
        public override String Area(int value)
        {
            Console.WriteLine("the area of given value is");
            int result = value * value;
            Console.WriteLine($"The final value is {result}");
            return "loss";
        }

    }
}

