
namespace IntegerOperations
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstFromFourNumbers = int.Parse(Console.ReadLine());
            int secondFromFourNumbers = int.Parse(Console.ReadLine());
            int thirdFromFourNumbers = int.Parse(Console.ReadLine());
            int fourthFromFourNumbers = int.Parse(Console.ReadLine());

            int firstTwoNumbersSum = firstFromFourNumbers + secondFromFourNumbers;
            int divisionOfTheSum = firstTwoNumbersSum / thirdFromFourNumbers;
            int product = divisionOfTheSum * fourthFromFourNumbers;

            Console.WriteLine(product);
        }
    }
}
