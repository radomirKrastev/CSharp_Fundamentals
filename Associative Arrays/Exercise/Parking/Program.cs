namespace Parking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var commandsNumber = int.Parse(Console.ReadLine());
            var userPlate = new Dictionary<string, string>();
           
            for (int i = 0; i < commandsNumber; i++)
            {
                var userData = Console.ReadLine().Split(" ").ToList();
                var command = userData[0];
                var user = userData[1];
                switch (command)
                {
                    case "register":
                        {
                            var plateNumber = userData[2];
                            if (!userPlate.ContainsKey(user))
                            {
                                userPlate[user] =plateNumber;
                                Console.WriteLine($"{user} registered {plateNumber} successfully");
                            }
                            else
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                            }
                        }
                        break;
                    case "unregister":
                        {
                            if (!userPlate.ContainsKey(user))
                            {
                                Console.WriteLine($"ERROR: user {user} not found");
                            }
                            else
                            {
                                userPlate.Remove(user);
                                Console.WriteLine($"{user} unregistered successfully");
                            }
                        }
                        break;
                }

            }
            
            foreach (var kvp in userPlate)
            {
                Console.WriteLine(kvp.Key+" => "+kvp.Value);
            }   
        }
    }
}
