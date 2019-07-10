
namespace MathPower
{
    using System;
    public class Program
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = PoweredNumber(number, power);
            Console.WriteLine(result);
        }

        public static double PoweredNumber(double number, int power)
        {
            double result = number;

            for (int i = 2; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
