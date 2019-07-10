
namespace SpecialNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int data = int.Parse(Console.ReadLine());
                        
            for (int i = 1; i <= data; i++)
            {
                int currentNumber = i;
                int sum = 0;
                while (currentNumber > 0)
                {
                    int lastDigit = currentNumber % 10;
                    sum += lastDigit;
                    currentNumber /= 10;
                }

                bool theNumberIsSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                
                    Console.WriteLine($"{i} -> {theNumberIsSpecial}");
                
            }
            
        }
    }
}
