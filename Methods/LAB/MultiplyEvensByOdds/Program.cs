
namespace MultiplyEvensByOdds
{
    using System;
    using System.Linq;
    public class Program
    {

        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOdds(Math.Abs(input));
            Console.WriteLine(result);
        }

        public static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetEvenNumbersSum(number) * GetOddNumbersSum(number);
        }

        public static int GetEvenNumbersSum(int number)
        {
            int evenNumbersSum = 0;

            while (number > 0)
            {
                int value = number % 10;

                if (value % 2 == 0)
                {
                    evenNumbersSum += value;
                }

                number /= 10;
            }

            return evenNumbersSum;
        }

        public static int GetOddNumbersSum(int number)
        {
            int oddNumbersSum = 0;

            while (number > 0)
            {
                int value = number % 10;

                if (value % 2 != 0)
                {
                    oddNumbersSum += value;
                }

                number /= 10;
            }

            return oddNumbersSum;
        }
    }
}
