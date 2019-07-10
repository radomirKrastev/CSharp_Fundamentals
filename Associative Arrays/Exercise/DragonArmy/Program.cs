namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var dragonsNumber = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, Dictionary<string, List<int>>>();
            
            for (int i = 0; i < dragonsNumber; i++)
            {
                var dragonData = Console.ReadLine().Split();
                var type = dragonData[0];
                var name = dragonData[1];
                int damage = 45;
                int health = 250;
                int armor = 10;

                if ((dragonData[2])!="null")
                {
                    damage = int.Parse(dragonData[2]);
                }

                if ((dragonData[3]) != "null")
                {
                    health = int.Parse(dragonData[3]);
                }

                if ((dragonData[4]) != "null")
                {
                    armor = int.Parse(dragonData[4]);
                }

                var dragonStats = new Dictionary<string, List<int>>();
                var stats = new List<int> { damage, health, armor };
                
                if (dragons.ContainsKey(type) && dragons[type].ContainsKey(name))
                {
                    dragons[type].Remove(name);
                    dragons[type].Add(name, stats);
                }

                else if (dragons.ContainsKey(type))
                {                    
                    dragons[type].Add(name,stats);
                }

                else
                {
                    dragonStats.Add(name, stats);
                    dragons.Add(type, dragonStats);
                }                
            }

            foreach (var dragonType in dragons)
            {
                Console.WriteLine($"{dragonType.Key}::" +
                    $"({dragonType.Value.Select(x => x.Value[0]).Average():F2}" +
                    $"/{dragonType.Value.Select(x => x.Value[1]).Average():F2}" +
                    $"/{dragonType.Value.Select(x => x.Value[2]).Average():F2})");

                foreach (var dragon in dragonType.Value.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
