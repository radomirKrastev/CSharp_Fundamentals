namespace ProblemThree
{
    using System;
    using System.Linq;
    
    class Program
    {
        static void Main()
        {
            double energy = 100;
            double coins = 100;
            var workingDayEvents = Console.ReadLine().Split("|").ToList();
            bool daycompleted = true;

            for (int i = 0; i < workingDayEvents.Count; i++)
            {
                var dayEvent = workingDayEvents[i].Split("-");
                if (dayEvent[0] == "rest")
                {
                    var energyGained = double.Parse(dayEvent[1]);
                    if (energyGained + energy <= 100)
                    {
                        energy += energyGained;
                        Console.WriteLine($"You gained {energyGained} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }

                    else
                    {
                        energyGained = 100 - energy;
                        energy += energyGained;
                        Console.WriteLine($"You gained {energyGained} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }

                }

                else if (dayEvent[0]== "order")
                {
                    if (energy >= 30)
                    {
                        var coinsEarned = double.Parse(dayEvent[1]);
                        coins += coinsEarned;
                        energy -= 30;
                        Console.WriteLine($"You earned {coinsEarned} coins.");
                    }

                    else
                    {
                        Console.WriteLine("You had to rest!");
                        energy += 50;
                    }
                }

                else
                {
                    var ingredient = dayEvent[0];
                    var price = double.Parse(dayEvent[1]);

                    if (coins > price)
                    {
                        Console.WriteLine($"You bought {ingredient}.");
                        coins -= price;
                    }

                    else
                    {
                        daycompleted = false;
                        Console.WriteLine($"Closed! Cannot afford {ingredient}.");
                        break;
                    }
                }
            }

            if (daycompleted == true)
            {
                Console.WriteLine($"Day completed!");
                Console.WriteLine($"Coins: {coins}");     
                Console.WriteLine($"Energy: {energy}");   
            }

        }
    }
}
