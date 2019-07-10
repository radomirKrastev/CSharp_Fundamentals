namespace Judge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var contestUserPoints = new Dictionary<string, Dictionary<string, int>>();
            while (input!="no more time")
            {
                var data = input.Split(" -> ");
                var user = data[0];
                var contest = data[1];
                var points = int.Parse(data[2]);                
                var userPoints = new Dictionary<string, int>();
                if (!contestUserPoints.ContainsKey(contest))
                {
                    userPoints.Add(user, points);
                    contestUserPoints.Add(contest, userPoints);
                }

                else
                {
                    userPoints = contestUserPoints[contest];
                    if (!userPoints.ContainsKey(user))
                    {
                        contestUserPoints[contest].Add(user,points);
                    }

                    if (userPoints[user] < points)
                    {
                        contestUserPoints[contest].Remove(user);
                        contestUserPoints[contest].Add(user, points);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in contestUserPoints)
            {
                Console.WriteLine(kvp.Key+": "+kvp.Value.Count()+" participants");
                var counter = 0;
                foreach (var kvpValue in kvp.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    counter++;
                    Console.WriteLine(counter+". "+kvpValue.Key + " <::> " + kvpValue.Value);
                }
            }

            var totalUserPoints = new Dictionary<string, int>();

            foreach (var kvp in contestUserPoints)
            {

                foreach (var kvpValue in kvp.Value)
                {
                    if (!totalUserPoints.ContainsKey(kvpValue.Key))
                    {
                        totalUserPoints.Add(kvpValue.Key,0);
                    }
                    totalUserPoints[kvpValue.Key] += kvpValue.Value;
                }
            }

            Console.WriteLine("Individual standings:");
            var totalPointscounter = 1;
            foreach (var kvp in totalUserPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine(totalPointscounter+". "+kvp.Key+" -> "+kvp.Value);
                totalPointscounter++;
            }
        }
    }
}
