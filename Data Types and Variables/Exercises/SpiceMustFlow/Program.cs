namespace SpiceMustFlow
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());
            int spiceYieldEachDay = startingYield;
            int minedSpice = 0;
            int daysOperated = 0;

            if (startingYield >= 100)
            {
                
                while (spiceYieldEachDay >= 100)
                {
                    minedSpice += GetTotalSpiceMined(spiceYieldEachDay);
                    spiceYieldEachDay -= 10;
                    daysOperated++;
                }
                minedSpice -= 26;
            }
            

            Console.WriteLine(daysOperated);
            Console.WriteLine(minedSpice);
        }

        public static int GetTotalSpiceMined (int spiceEachDay)
        {
            int totalMined = spiceEachDay - 26;
            return totalMined;
        }
    }
}
