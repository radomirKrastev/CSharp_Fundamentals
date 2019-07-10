namespace ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var forceUsers = new Dictionary<string, List<string>>();
            var command = Console.ReadLine();
            while (command != "Lumpawaroo")
            {
                var sideUser = new List<string>();
                var isUserStored = false;
                if (command.Contains(" | "))
                {
                    sideUser = command.Split(" | ").ToList();
                    var side = sideUser[0];
                    var user = sideUser[1];
                    isUserStored = false;

                    if (!forceUsers.ContainsKey(side))
                    {
                        forceUsers[side] = new List<string>();
                    }

                    isUserStored = UserPresent(forceUsers, user);

                    if (!isUserStored)
                    {
                        forceUsers[side].Add(user);
                    }
                    
                }
                else
                {
                    sideUser = command.Split(" -> ").ToList();
                    var side = sideUser[1];
                    var user = sideUser[0];

                    if (!forceUsers.ContainsKey(side))
                    {
                        forceUsers[side] = new List<string>();
                    }

                    isUserStored = UserPresent(forceUsers, user);

                    if (isUserStored)
                    {
                        foreach (var kvp in forceUsers)
                        {
                            if (kvp.Value.Contains(user))
                            {
                                kvp.Value.Remove(user);
                            }
                        }

                        forceUsers[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }

                    else
                    {
                        forceUsers[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }

                command = Console.ReadLine();
            }

             var finalUsers = forceUsers
                        .Where(x => x.Value.Count > 0)
                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in finalUsers.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                Console.WriteLine("! " +string.Join(Environment.NewLine+"! ",kvp.Value.OrderBy(x=>x)));
            }
        }

        public static bool UserPresent(Dictionary<string, List<string>> forceUsers, string user)
        {
            bool isUserStored = false;
            foreach (var kvp in forceUsers)
            {
                if (kvp.Value.Contains(user))
                {
                    isUserStored = true;
                    break;
                }
            }

            return isUserStored;
        }
    }
}
