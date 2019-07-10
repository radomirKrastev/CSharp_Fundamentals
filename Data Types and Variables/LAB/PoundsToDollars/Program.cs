
namespace PoundsToDollars
{
    using System;
    public class Program
    {
        public static void Main()
        {
            double poundsGiven = double.Parse(Console.ReadLine());

            double dollars = poundsGiven * 1.31;
            Console.WriteLine($"{dollars:F3}");
        }
    }
}
