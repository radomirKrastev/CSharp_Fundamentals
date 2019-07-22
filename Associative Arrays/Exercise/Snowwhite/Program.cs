namespace Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dwarfData = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Once upon a time")
            {
                var characteristics = input.Split(" <:> ");
                var name = characteristics[0];
                var hatColor = characteristics[1];
                var physics = int.Parse(characteristics[2]);
                var namePhysics = new Dictionary<string, int>();
                if (!dwarfData.ContainsKey(hatColor))
                {
                    namePhysics.Add(name, physics);
                    dwarfData.Add(hatColor, namePhysics);
                }

                else
                {
                    if (dwarfData.ContainsKey(hatColor))
                    {
                        namePhysics = dwarfData[hatColor];
                        if (namePhysics.ContainsKey(name))
                        {

                            if (physics > namePhysics[name])
                            {
                                dwarfData[hatColor].Remove(name);
                                dwarfData[hatColor].Add(name, physics);
                            }
                        }

                        else
                        {
                            namePhysics.Add(name, physics);
                            dwarfData[hatColor] = namePhysics;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var dwarfs = new Dictionary<string, int>();

            foreach (var kvp in dwarfData)
            {
                foreach (var kvpValue in kvp.Value)
                {
                    dwarfs[kvp.Key + "->" + kvpValue.Key] = kvpValue.Value;
                }
            }

            foreach (var kvp in dwarfs
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfs.Where(y => y.Key.Split("->")[0] == x.Key.Split("->")[0]).Count()))

            {
                var name = kvp.Key.Split("->")[1];
                var hat = kvp.Key.Split("->")[0];
                var physics = kvp.Value;

                Console.WriteLine($"({hat}) {name} <-> {physics}");
            }
        }
    }
}
