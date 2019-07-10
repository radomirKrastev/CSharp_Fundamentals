namespace RefactoringPrimeNumber
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int endValue = int.Parse(Console.ReadLine());
            for (int i = 2; i <= endValue; i++)
            {
                bool isTheNumberPrime = true;
                for (int divider = 2; divider < i; divider++)
                {
                    if (i % divider == 0)
                    {
                        isTheNumberPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, (isTheNumberPrime.ToString().ToLower()));
            }

        }
    }
}
