namespace TextFilter
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(", ");
            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                var replacement = new string('*', word.Length);
                text = text.Replace(word, replacement);
            }

            Console.WriteLine(text);
        }
    }
}
