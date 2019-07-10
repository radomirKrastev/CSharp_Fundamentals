
namespace SortNumbers
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int greatestNumber = Math.Max(Math.Max(thirdNumber,firstNumber), secondNumber);
            int lowestNumber = Math.Min(Math.Min(thirdNumber,firstNumber), secondNumber);
            int middleNumber = (firstNumber + secondNumber + thirdNumber) - (greatestNumber + lowestNumber);

            Console.WriteLine(greatestNumber);
            Console.WriteLine(middleNumber);
            Console.WriteLine(lowestNumber);

        }
    }
}
