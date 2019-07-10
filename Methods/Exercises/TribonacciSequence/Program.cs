namespace TribonacciSequence
{
    using System;
    public class Program
    {
        public static void Main()
        {
            uint numberInput = uint.Parse(Console.ReadLine());

            uint[] tribonacciArray = new uint[numberInput];

            for (int i = 0; i < numberInput; i++)
            {
                if (i == 0)
                {
                    tribonacciArray[i] = 1;
                }
                else if (i == 1)
                {
                    tribonacciArray[i] = 1;
                }
                else if (i == 2)
                {
                    tribonacciArray[i] = 2;
                }
                else
                {
                    tribonacciArray[i] = tribonacciArray[i - 1] + tribonacciArray[i - 2] + tribonacciArray[i - 3];
                }

            }

            Console.WriteLine(string.Join(" ",tribonacciArray));

        }
    }
}
