namespace Annapurna
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            var supplies = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var command = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                var store = command[1];

                if (command.Length == 3)
                {
                    var items = command[2].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (!supplies.ContainsKey(store))
                    {
                        supplies[store] = new List<string>();
                    }

                    supplies[store].AddRange(items);
                }

                else
                {
                    supplies.Remove(store);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Stores list:");
            foreach (var store in supplies.OrderByDescending(x=>x.Value.Count()).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine(store.Key);

                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{string.Join("",item)}>>");
                }
            }
        }
    }
}
