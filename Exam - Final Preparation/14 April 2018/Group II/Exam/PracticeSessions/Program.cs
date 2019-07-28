namespace PracticeSessions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var racingRoads = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var command = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Add")
                {
                    var road = command[1];
                    var racer = command[2];

                    if (!racingRoads.ContainsKey(road))
                    {
                        var racers = new List<string>();
                        racingRoads.Add(road, racers);
                    }

                    racingRoads[road].Add(racer);
                }

                else if (command[0] == "Move")
                {
                    var currendRoad = command[1];
                    var racer = command[2];
                    var nextRoad = command[3];
                    var racers = racingRoads[currendRoad];

                    if (racers.Contains(racer))
                    {
                        racingRoads[currendRoad].Remove(racer);
                        racingRoads[nextRoad].Add(racer);
                    }
                }

                else
                {
                    var road = command[1];

                    if (racingRoads.ContainsKey(road))
                    {
                        racingRoads.Remove(road);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Practice sessions:");

            foreach (var road in racingRoads.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine(road.Key);

                foreach (var currentRoad in road.Value)
                {
                    Console.WriteLine("++"+string.Join(Environment.NewLine+"++", currentRoad));
                }
            }
        }
    }
}
