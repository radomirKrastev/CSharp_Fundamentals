namespace LegendaryFarming
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var legendaryItemsMats = new Dictionary<string, int>();

            legendaryItemsMats["shards"] = 0;
            legendaryItemsMats["fragments"] = 0;
            legendaryItemsMats["motes"] = 0;

            bool legendaryItemAquired = false;
            string aquiredLegendaryMaterial = "";
            var junkItemsMats = new Dictionary<string, int>();

            while (legendaryItemAquired == false)
            {
                var data = Console.ReadLine().Split(" ").ToList();
                int materialQuantity = 0;
                string material = "";
                for (int i = 0; i < data.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        materialQuantity = int.Parse(data[i]);
                        material = data[i + 1].ToLower();
                    }

                    else
                    {
                        continue;
                    }

                    if (legendaryItemsMats.ContainsKey(material))
                    {
                        legendaryItemsMats[material] += materialQuantity;
                        if (legendaryItemsMats[material] >= 250)
                        {
                            legendaryItemAquired = true;
                            aquiredLegendaryMaterial = material;
                            legendaryItemsMats[material] -= 250;
                            break;
                        }
                    }

                    else
                    {
                        if (!junkItemsMats.ContainsKey(material))
                        {
                            junkItemsMats[material] = 0;
                        }
                        junkItemsMats[material] += materialQuantity;
                    }
                }
            }
                       
            if (aquiredLegendaryMaterial == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }

            else if (aquiredLegendaryMaterial == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }

            else
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            legendaryItemsMats=legendaryItemsMats
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp=>kvp.Key,kvp=>kvp.Value);
            foreach (var kvp in legendaryItemsMats)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }

            junkItemsMats=junkItemsMats
                .OrderBy(kvp => kvp.Key)
                .ThenBy(kvp => kvp.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var kvp in junkItemsMats)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
        }
    }    
}
