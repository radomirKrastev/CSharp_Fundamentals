namespace Train
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<int> passengerWagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxPassengers = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "end")
            {
                if (command.Count == 1)
                {
                     passengerWagons=GetAdditionalPassengers(passengerWagons, maxPassengers, command);
                }
                else
                {
                    if (int.Parse(command[1]) <= maxPassengers)
                    {
                        passengerWagons.Add(int.Parse(command[1]));
                    }                    
                }
                
                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", passengerWagons));
        }

        
        public static List<int> GetAdditionalPassengers(List<int> passengerWagons, int maxPassengers, List<string> command)
        {

            int additionalPassengers = int.Parse(command[0]);
            for (int i = 0; i < passengerWagons.Count; i++)
            {
                if (passengerWagons[i] + additionalPassengers <= maxPassengers)
                {
                    passengerWagons[i] += additionalPassengers;
                    break;
                }
            }

            return passengerWagons;
        }
    }
}
