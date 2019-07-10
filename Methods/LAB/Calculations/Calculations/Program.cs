namespace Calculations
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string action = Console.ReadLine();

            double number1 =double.Parse(Console.ReadLine());
            double number2 =double.Parse(Console.ReadLine());

            switch (action)
            {
                case "add":
                    PrintAdding(number1, number2);
                    break;
                case "multiply":
                    PrintMultiplication(number1, number2);
                    break;
                case "divide":
                    PrintDivision(number1, number2);
                    break;
                case "subtract":
                    PrintSubtraction(number1, number2);
                    break;
            }
        }

        public static void PrintAdding(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber+secondNumber);
        }

        public static void PrintMultiplication(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        public static void PrintSubtraction(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }

        public static void PrintDivision(double firstNumber, double secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }

    }
}
