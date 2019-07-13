namespace Race
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();
            var racersStats = new Dictionary<string, double>();

            while(input!="end of race")
            {
                var name = Regex.Split(input, @"[^A-Za-z]");
                var nameStr = string.Empty;

                foreach (var str in name)
                {
                    nameStr += str;
                }

                if (participants.Contains(nameStr))
                {
                    var distance = Regex.Split(input, @"[^\d]");
                    var distanceStr = string.Empty;

                    foreach (var str in distance)
                    {
                        distanceStr += str;
                    }

                    var distanceKm = 0.0;

                    foreach (var c in distanceStr)
                    {
                        distanceKm += double.Parse(c.ToString());
                    }

                    if (!racersStats.ContainsKey(nameStr))
                    {
                        racersStats.Add(nameStr,0);
                    }

                    racersStats[nameStr] += distanceKm;
                }

                input = Console.ReadLine();                
            }

            var finalists = new List<string>();

            foreach (var racer in racersStats.OrderByDescending(x => x.Value).Take(3))
            {
                finalists.Add(racer.Key);
            }

            Console.WriteLine($"1st place: {finalists[0]}");
            Console.WriteLine($"2nd place: {finalists[1]}");
            Console.WriteLine($"3rd place: {finalists[2]}");
        }
    }
}
