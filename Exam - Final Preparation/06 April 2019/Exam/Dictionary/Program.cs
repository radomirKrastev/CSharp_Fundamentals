

namespace Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var wordsData = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var definitions = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = Console.ReadLine();

            var dictionary = new Dictionary<string, List<string>>();

            foreach (var data in wordsData)
            {
                var word = data.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                var definition = data.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                }

                dictionary[word].Add(definition);
            }

            foreach (var word in definitions)
            {
                if (dictionary.ContainsKey(word))
                {
                    Console.WriteLine(word);
                    foreach (var definition in dictionary[word].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine(" -" + definition);
                    }
                }
            }

            if (command == "List")
            {
                var wordsList = new List<string>();

                foreach (var word in dictionary.OrderBy(x => x.Key))
                {
                    wordsList.Add(word.Key.Trim());
                }

                Console.WriteLine(string.Join(" ", wordsList));
            }
        }
    }
}
