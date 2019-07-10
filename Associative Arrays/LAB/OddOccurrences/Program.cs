namespace OddOccurrences
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split(' ').ToList();
            var occurrences = new Dictionary<string, int>();

            foreach (var element in data)
            {
                if (!occurrences.ContainsKey(element.ToLower()))
                {
                    occurrences[element.ToLower()] = 0;
                }
                occurrences[element.ToLower()]++;
            }

            var oddOccurrences = new List<string>();
            foreach (var kvp in occurrences)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddOccurrences.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(" ",oddOccurrences));

        }
    }
}
