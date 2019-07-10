
namespace SmallestOfThreeNumbers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            PrintSmallestNumber(number1, number2, number3);
        }

        public static void PrintSmallestNumber(int number1, int number2, int number3)
        {
            int result = Math.Min(number1,Math.Min(number2, number3));
            Console.WriteLine(result);
        }
    }
}
