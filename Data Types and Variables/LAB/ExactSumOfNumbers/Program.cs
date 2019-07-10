
namespace ExactSumOfNumbers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            decimal sumOfNumbers = 0;
            for (int i = 1; i <= countOfNumbers; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                sumOfNumbers += currentNumber;
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
