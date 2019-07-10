

namespace SignOfIntegerNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintsSignOfNumber(number);
        }

        public static void PrintsSignOfNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }

            else if (number == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }

            else
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}
