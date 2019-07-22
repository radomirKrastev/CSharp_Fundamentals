namespace EmojiSumator
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var message = Console.ReadLine();
            var codedEmoji = Console.ReadLine()
                .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                       
            var decodedEmoji = string.Empty;

            foreach (var code in codedEmoji)
            {
                char symbol = (char)code;
                decodedEmoji += symbol.ToString();
            }

            var emojiPattern = @"(?<=[ |\t])(?<emoji>[:][a-z]{4,}[:])(?=\[\t| |,|.|!|\?])";

            MatchCollection rawEmojis = Regex.Matches(message, emojiPattern);
            var validEmojis = new List<string>();

            foreach (Match match in rawEmojis)
            {
                validEmojis.Add(match.Groups["emoji"].Value);
            }

            var emojiPower = 0;

            foreach (var emoji in validEmojis)
            {
                foreach (var ch in emoji.Where(c=>c!=':'))
                {
                    int symbolPower = (int)(ch);
                    emojiPower += symbolPower;
                }
            }

            foreach (var emoji in validEmojis)
            {
                if (emoji.Trim(':') == decodedEmoji)
                {
                    emojiPower *= 2;
                }
            }

            if (validEmojis.Count > 0)
            {
                Console.WriteLine("Emojis found: " + string.Join(", ", validEmojis));
            }            
            Console.WriteLine("Total Emoji Power: " +emojiPower);
        }
    }
}
