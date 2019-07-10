
namespace RefactorSpecialNumbers
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
                    sum += currentNumber % 10;
                    currentNumber/=10;
                }

                bool isNumberSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine(i+" -> "+isNumberSpecial);
                
            }

        }
    }
}
