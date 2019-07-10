namespace WordSynonyms
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            int wordsCount = int.Parse(Console.ReadLine());
            var wordSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordSynonyms.ContainsKey(word))
                {
                    wordSynonyms[word] =new List<string>();
                }
                wordSynonyms[word].Add(synonym);
            }

            foreach (var kvp in wordSynonyms)
            {
                Console.WriteLine(kvp.Key+" - "+string.Join(", ",kvp.Value));
            }
        }
    }
}
