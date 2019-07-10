namespace CharsCount
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<string> data = Console.ReadLine().Split(' ').ToList();

            var charsCount = new Dictionary<char, int>();

            foreach (var s in data)
            {
                foreach (var c in s)
                {
                    if (!charsCount.ContainsKey(c))
                    {
                        charsCount.Add(c, 0);
                    }

                    charsCount[c]++;
                }                
            }

            foreach (var kvp in charsCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
