namespace PresentDelivery
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var houseHolds = Console.ReadLine().Split('@').Select(int.Parse).ToList();

            var command = Console.ReadLine();
            var currentPosition = 0;

            while (command!="Merry Xmas!")
            {
                var jumpLength = int.Parse(command.Split()[1]);

                for (int i = 1; i <= jumpLength; i++)
                {
                    currentPosition++;
                    if (currentPosition > houseHolds.Count - 1)
                    {
                        currentPosition = 0;
                    }
                }

                if (houseHolds[currentPosition]==0)
                {
                    Console.WriteLine($"House {currentPosition} will have a Merry Christmas.");
                }

                else
                {
                    houseHolds[currentPosition] -= 2;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Santa's last position was {currentPosition}.");

            if (houseHolds.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }

            else
            {
                var failedHousesCount = 0;
                foreach (var house in houseHolds.Where(x=>x>0))
                {
                    failedHousesCount++;
                }
                Console.WriteLine($"Santa has failed {failedHousesCount} houses.");
            }

        }
    }
}
