namespace ProblemThree
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var partySize = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());

            var totalGold = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }

                if (i % 15 == 0)
                {
                    partySize += 5;
                }

                totalGold += 50 - (partySize * 2);

                if (i % 5 == 0)
                {
                    totalGold += 20 * partySize;
                    if (i % 3 == 0)
                    {
                        totalGold -= 5 * partySize;
                    }
                }

                else if (i % 3 == 0)
                {
                    totalGold -= 3 * partySize;
                }
            }

            var goldPerCompanion = totalGold / partySize;
            Console.WriteLine($"{partySize} companions received {goldPerCompanion} coins each.");
        }
    }
}
