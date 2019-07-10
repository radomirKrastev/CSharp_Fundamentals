namespace ProblemOne
{
    using System;
    public class Program
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double flourPriceKg = double.Parse(Console.ReadLine());
            double eggsPackPrice = flourPriceKg * 0.75;
            double literOfMilk = (flourPriceKg * 0.25) + flourPriceKg;
            double quarterOfMilk = literOfMilk / 4;
            double cozunacPrice = quarterOfMilk + eggsPackPrice + flourPriceKg;
            int countOfCozonacs = 0;
            int eggsTotal = 0;
            while (budget >= cozunacPrice)
            {
                budget -= cozunacPrice;
                countOfCozonacs++;
                eggsTotal += 3;
                if (countOfCozonacs % 3 == 0)
                {
                    var lostEggs = countOfCozonacs -2;
                    eggsTotal -= lostEggs;
                }

            }


            Console.WriteLine($"You made {countOfCozonacs} cozonacs! Now you have {eggsTotal} eggs and {budget:F2}BGN left.");
        }
    }
}
