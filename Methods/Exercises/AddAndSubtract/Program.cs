
namespace AddAndSubtract
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSubtractedValue(firstNumber,secondNumber,thirdNumber));
        }

        public static int GetSubtractedValue (int firstNumber, int secondNumber, int thirdNumber)
        {
            int sum = Sum(firstNumber, secondNumber);
            int result = sum - thirdNumber;
            return result;            
        }

        public static int Sum (int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

    }
}
