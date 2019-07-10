namespace Division
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int data = int.Parse(Console.ReadLine());

            if (GetHighestDivision(data) == 0)
            {
                Console.WriteLine("Not divisible");
            }

            else
            {
                Console.WriteLine("The number is divisible by " + GetHighestDivision(data));
            }
        }

        public static int GetHighestDivision (int number)
        {
            int division = 0;
            
            if (IsNumberDivisibleBy2(number)==true)
            {
                division = 2;
            }

            if (IsNumberDivisibleBy3(number) == true)
            {
                division = 3;
            }

            if (IsNumberDivisibleBy6(number) == true)
            {
                division = 6;
            }

            if (IsNumberDivisibleBy7(number) == true)
            {
                division = 7;
            }

            if (IsNumberDivisibleBy10(number) == true)
            {
                division = 10;
            }

            return division;
        }

        public static bool IsNumberDivisibleBy2(int number)
        {
            bool numberIsDivisible = false;
            if (number%2 == 0)
            {
                numberIsDivisible = true;
            }

            return numberIsDivisible;
        }

        public static bool IsNumberDivisibleBy3(int number)
        {
            bool numberIsDivisible = false;
            if (number % 3 == 0)
            {
                numberIsDivisible = true;
            }

            return numberIsDivisible;
        }

        public static bool IsNumberDivisibleBy7(int number)
        {
            bool numberIsDivisible = false;
            if (number % 7 == 0)
            {
                numberIsDivisible = true;
            }

            return numberIsDivisible;
        }

        public static bool IsNumberDivisibleBy10(int number)
        {
            bool numberIsDivisible = false;
            if (number % 10 == 0)
            {
                numberIsDivisible = true;
            }

            return numberIsDivisible;
        }

        public static bool IsNumberDivisibleBy6(int number)
        {
            bool numberIsDivisible = false;
            if (number % 6 == 0)
            {
                numberIsDivisible = true;
            }

            return numberIsDivisible;
        }
    }

}
