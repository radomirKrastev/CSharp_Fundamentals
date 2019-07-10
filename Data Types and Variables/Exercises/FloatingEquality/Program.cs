namespace FloatingEquality
{
    using System;
    public class Program
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double constant = 0.000001;
            double difference = Math.Abs(firstNumber - secondNumber);

            bool areNumbersEqual = difference < constant;
            Console.WriteLine(areNumbersEqual);
        }
    }
}
