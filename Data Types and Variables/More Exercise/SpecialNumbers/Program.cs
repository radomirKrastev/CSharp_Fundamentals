using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            

            for(int i = 1; i<=number; i++)
            {
                int everyNumber = i;
                int sum = 0;
                while (everyNumber != 0)
                {
                    int lastDigit = everyNumber % 10;
                    everyNumber = everyNumber / 10;

                    sum += lastDigit;

                }

                if (sum == 5 || sum ==7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                
            }

            
           

        }
    }
}
