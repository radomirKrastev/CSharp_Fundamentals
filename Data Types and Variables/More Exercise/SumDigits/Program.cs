using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberAsString = number.ToString();

            int sum = 0;

            for(int i = 0; i<numberAsString.Length; i++)
            {
                string digitAsString = numberAsString[i].ToString();
                int digitValue = int.Parse(digitAsString);
                sum += digitValue;
            }
            Console.WriteLine(sum);


        }
    }
}
