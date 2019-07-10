namespace RandomizeWords
{
    using System;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToList();
            var randomEl = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var randomNumber = randomEl.Next(0, words.Count);

                var randomElement = words[randomNumber];
                var currentElement = words[i];

                words[randomNumber] = currentElement;
                words[i] = randomElement;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
