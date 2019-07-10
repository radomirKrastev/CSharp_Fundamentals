namespace SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var userPoints = new Dictionary<string, int>();
            var languageUsers = new Dictionary<string, List<string>>();


            while (command != "exam finished")
            {
                var result = command.Split("-");
                var user = result[0];
                if (!command.Contains("banned"))
                {
                    var language = result[1];
                    var points = int.Parse(result[2]);

                    if (!languageUsers.ContainsKey(language))
                    {
                        languageUsers[language] = new List<string>();
                    }

                    if (!userPoints.ContainsKey(user))
                    {
                        userPoints[user] = points;
                    }

                    else
                    {
                        if (points > userPoints[user])
                        {
                            userPoints[user] = points;
                        }
                    }

                    languageUsers[language].Add(user);
                }

                else
                {
                    userPoints.Remove(user);
                }

                command = Console.ReadLine();
            }


            Console.WriteLine("Results:");
            foreach (var kvp in userPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }

            Console.WriteLine("Submissions:");
            foreach (var kvp in languageUsers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value.Count);
            }
        }
    }
}
