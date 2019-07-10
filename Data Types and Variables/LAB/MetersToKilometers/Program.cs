
namespace MetersToKilometers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int metersGiven = int.Parse(Console.ReadLine());

            double kilometers = metersGiven / 1000D;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
