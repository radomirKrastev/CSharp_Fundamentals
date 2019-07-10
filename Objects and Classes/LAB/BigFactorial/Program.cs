namespace BigFactorial
{
    using System;
    using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            BigInteger result = new BigInteger(number);

            for (int i = number-1; i >= 1; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
