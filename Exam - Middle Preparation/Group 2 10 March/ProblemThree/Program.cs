namespace ProblemThree
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var playersCount = int.Parse(Console.ReadLine());
            var groupEnergy = decimal.Parse(Console.ReadLine());
            var waterPerDay = decimal.Parse(Console.ReadLine());
            var totalWater = waterPerDay * days * playersCount;
            var foodPerDay = decimal.Parse(Console.ReadLine());
            var totalFood = foodPerDay * days * playersCount;

            for (int i = 1; i <= days; i++)
            {              

                if (groupEnergy>0)
                {
                    var energyLoss = decimal.Parse(Console.ReadLine());
                    groupEnergy -= energyLoss;

                    if (groupEnergy <= 0)
                    {
                        Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
                        break;
                    }

                    if (i % 2 == 0)
                    {
                        groupEnergy += (groupEnergy * 0.05m);
                        totalWater -= (totalWater * 0.3m);
                    }

                    if (i % 3 == 0)
                    {
                       

                        if(playersCount>0)
                        {
                            totalFood -= (totalFood / playersCount);
                        }
                        
                        groupEnergy += (groupEnergy * 0.1m);
                    }
                }
                               
            }

            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }
            
        }
    }
}
