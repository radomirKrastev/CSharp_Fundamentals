
namespace MathOperations
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            double result = 0;
            switch (action)
            {
                case "+":
                    result = GetSum(firstNumber, secondNumber);
                    break;
                case "*":
                    result = GetMultiplying(firstNumber, secondNumber);
                    break;
                case "/":
                    result = GetDivision(firstNumber, secondNumber);
                    break;
                case "-":
                    result = GetSubtraction(firstNumber, secondNumber);
                    break;
            }
            Console.WriteLine(result);
        }

        public static double GetSum (double first, double second)
        {
           double result = first + second;
            return result;
        }

        public static double GetMultiplying(double first, double second)
        {
            double result = first * second;
            return result;
        }

        public static double GetDivision(double first, double second)
        {
            double result = first / second;
            return result;
        }

        public static double GetSubtraction(double first, double second)
        {
            double result = first - second;
            return result;
        }
    }
}
