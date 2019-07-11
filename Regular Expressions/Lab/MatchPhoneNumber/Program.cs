namespace MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var regex = @"([+]359 2 \d{3} \d{4})|([+]359-2-\d{3}-\d{4})\b";
            var phoneNumbers = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phoneNumbers, regex);

            var legitPhoneNumbers = phoneMatches
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ", legitPhoneNumbers));
        }
    }
}
