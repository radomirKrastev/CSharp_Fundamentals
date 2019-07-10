namespace MinerTask
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            var dataList = new List<string>();

            while (command != "stop")
            {
                dataList.Add(command);
                command = Console.ReadLine();
            }

            var metalQuantity = new Dictionary<string, int>();
            for (int i = 0; i < dataList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    if (!metalQuantity.ContainsKey(dataList[i]))
                    {
                        metalQuantity[dataList[i]] = 0;
                    }

                }
                else
                {
                    metalQuantity[dataList[i - 1]] += int.Parse(dataList[i]);
                }
            }

            foreach (var kvp in metalQuantity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
