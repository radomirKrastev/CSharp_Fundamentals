
namespace SumOfDigits
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int numberData = int.Parse(Console.ReadLine());
            int sum = 0;
            while (numberData != 0)
            {
                sum += numberData % 10;
                numberData /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
