
namespace FactorialDivision
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"{GetDivisionResult(firstNumber,secondNumber):F2}");
        }

        public static double GetDivisionResult (long firstFactorial, long secondFactorial)
        {
            double divisionResult = GetFirstFactorial(firstFactorial)*1.0 / GetSecondFactorial(secondFactorial);
            return divisionResult;
        }

        public static long GetFirstFactorial(long firstNumber)
        {
            long result = firstNumber;

            if (firstNumber == 0)
            {
                result = 1;
            }

            for (long i = firstNumber-1; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }

        public static long GetSecondFactorial(long secondNumber)
        {
            long result = secondNumber;

            if (secondNumber == 0)
            {
                result = 1;
            }

            for (long i = secondNumber-1; i > 0; i--)
            {
                result *=  i;
            }

            return result;
        }

    }
}
