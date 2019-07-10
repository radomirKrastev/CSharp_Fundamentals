namespace FromLeftToTheRight
{
    using System;
    using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            int countOfLines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfLines; i++)
            {
                string[] dataInput = Console.ReadLine().Split();
                BigInteger leftNumber = BigInteger.Parse(dataInput[0]);
                BigInteger rightNumber = BigInteger.Parse(dataInput[1]);

                int greaterNumberDigitsSum = 0;
                if (leftNumber > rightNumber)
                {
                    while (leftNumber != 0)
                    {
                        greaterNumberDigitsSum += (int)(leftNumber % 10);
                        leftNumber /= 10;
                    }
                }
                else
                {
                    while (rightNumber != 0)
                    {
                        greaterNumberDigitsSum += (int)(rightNumber % 10);
                        rightNumber /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(greaterNumberDigitsSum));
            }
        }
    }
}
