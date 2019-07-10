namespace TypeOfGrade
{
    using System;

    public class Program
    {
        public static void Main()
        {
            PrintsGradeCategory(double.Parse(Console.ReadLine()));
        }

        public static void PrintsGradeCategory(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }

            else if (grade >=3 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }

            else if (grade >= 3.5 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }

            else if (grade >= 4.5 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }

            else if (grade >= 5.5 && grade <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
