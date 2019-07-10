namespace ProblemOne
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var vacationDays = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var partySize = int.Parse(Console.ReadLine());
            var fuelPricePerKm = double.Parse(Console.ReadLine());
            var foodCostPerPerson = double.Parse(Console.ReadLine());
            var hotelCostPerPerson = double.Parse(Console.ReadLine());

            
            if (partySize > 10)
            {
                hotelCostPerPerson -= (hotelCostPerPerson * 0.25);
            }
                        
            double totalExpenses = ((foodCostPerPerson + hotelCostPerPerson) * partySize) * vacationDays;
            double remainingBudget = budget - totalExpenses;

            for (int i = 1; i <= vacationDays; i++)
            {
                var distance = double.Parse(Console.ReadLine());
                remainingBudget -= (distance * fuelPricePerKm);
                totalExpenses += distance * fuelPricePerKm;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    remainingBudget -= (totalExpenses * 0.4);
                    totalExpenses += totalExpenses * 0.4;
                }

                if (i % 7 == 0)
                {
                    remainingBudget += (totalExpenses / partySize);
                    totalExpenses-= (totalExpenses / partySize);
                }

                if (totalExpenses > budget)
                {
                    var difference = totalExpenses - budget;
                    Console.WriteLine($"Not enough money to continue the trip. You need {difference:F2}$ more.");
                    break;
                }
            }

            if (budget >= totalExpenses)
            {
                Console.WriteLine($"You have reached the destination. You have {remainingBudget:F2}$ budget left.");
            }
            
        }
    }
}
