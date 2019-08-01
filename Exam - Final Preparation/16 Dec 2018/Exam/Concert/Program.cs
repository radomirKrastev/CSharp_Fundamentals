namespace Concert
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var command = Console.ReadLine().Split(new string[] { "; "},StringSplitOptions.RemoveEmptyEntries);
            var bands = new Dictionary<string, Dictionary<int, List<string>>>();

            while(command[0]!="start of concert")
            {
                var name = command[1];

                if (command[0] == "Add")
                {                    
                    var members = command[2].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var data = new Dictionary<int, List<string>>();

                    if (!bands.ContainsKey(name))
                    {                        
                        data.Add(0, new List<string>());
                        bands.Add(name, data);
                    }

                    data = bands[name];
                    var time = 0;
                    foreach (var playTime in data)
                    {
                        time = playTime.Key;
                    }

                    bands[name][time].AddRange(members);
                    bands[name][time] = bands[name][time].Distinct().ToList();
                }

                else
                {
                    var data = new Dictionary<int, List<string>>();
                    var time = int.Parse(command[2]);

                    if (!bands.ContainsKey(name))
                    {
                        data.Add(0, new List<string>());
                        bands.Add(name, data);
                    }

                    data = bands[name];
                    var oldTime = 0;
                    var members = new List<string>();

                    foreach (var kvp in data)
                    {
                        oldTime = kvp.Key;
                        members.AddRange(kvp.Value);
                    }

                    var newTime = oldTime + time;
                    bands[name].Remove(oldTime);
                    bands[name].Add(newTime, members);
                }

                command= Console.ReadLine().Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);
            }

            var bandsData = new Dictionary<string, Band>();
            var totalTime = 0;
            foreach (var band in bands)
            {
                foreach (var data in band.Value)
                {
                    totalTime += data.Key;
                    var group = new Band { PlayTime = data.Key, Members = data.Value };
                    bandsData.Add(band.Key, group);
                }
            }

            Console.WriteLine($"Total time: {totalTime}");
            foreach (var band in bandsData.OrderByDescending(x=>x.Value.PlayTime).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value.PlayTime}");
            }

            var bandName = Console.ReadLine();
            Console.WriteLine(bandName);
            Console.WriteLine($"=> {string.Join(Environment.NewLine+"=> ",bandsData[bandName].Members)}");
        }
    }   
}
