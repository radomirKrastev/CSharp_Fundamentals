namespace Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var contestsEntry = Console.ReadLine();
            var contestPassword = new Dictionary<string, string>();
            while (contestsEntry != "end of contests")
            {
                var contestData = contestsEntry.Split(':');
                var name = contestData[0];
                var password = contestData[1];
                contestPassword[name] = password;
                contestsEntry = Console.ReadLine();
            }

            var participantContestPoints = new Dictionary<string, Dictionary<string, int>>();
            var participantEntry = Console.ReadLine();
            while (participantEntry != "end of submissions")
            {
                var participantData = participantEntry.Split("=>");
                var contest = participantData[0];
                var pass = participantData[1];
                var participantName = participantData[2];
                var points = int.Parse(participantData[3]);

                if (contestPassword.ContainsKey(contest) && contestPassword[contest] == pass)
                {
                    var contestPoints = new Dictionary<string, int>();
                    if (!participantContestPoints.ContainsKey(participantName))
                    {
                        contestPoints.Add(contest, points);
                        participantContestPoints.Add(participantName, contestPoints);
                    }

                    else
                    {
                        contestPoints = participantContestPoints[participantName];
                        if (!contestPoints.ContainsKey(contest))
                        {
                            participantContestPoints[participantName].Add(contest, points);
                        }

                        else
                        {
                            if (points > contestPoints[contest])
                            {
                                participantContestPoints[participantName].Remove(contest);
                                participantContestPoints[participantName].Add(contest, points);
                            }
                        }
                    }
                }

                participantEntry = Console.ReadLine();
            }

            var participantsTotalScore = new Dictionary<string, int>();
            foreach (var kvp in participantContestPoints)
            {
                participantsTotalScore.Add(kvp.Key, 0);
                foreach (var kvpValue in kvp.Value)
                {
                    participantsTotalScore[kvp.Key] += kvpValue.Value;
                }
            }

            int maxScore = participantsTotalScore.Max(x => x.Value);
            foreach (var kvp in participantsTotalScore.Where(x => x.Value == maxScore))
            {
                Console.WriteLine("Best candidate is " + kvp.Key + " with total " + kvp.Value + " points.");
            }

            Console.WriteLine("Ranking:");
            foreach (var kvp in participantContestPoints.OrderBy(x=>x.Key))
            {
                Console.WriteLine(kvp.Key);
                foreach (var kvpValue in kvp.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine("#"+kvpValue.Key + " -> " + kvpValue.Value);
                }
            }
        }
    }
}
