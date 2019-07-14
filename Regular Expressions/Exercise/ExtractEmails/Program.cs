namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine();
            var emailPattern = @"(^|(?<=\s))[a-zA-Z0-9]+[a-zA-Z0-9-_.]+[a-zA-Z0-9]+(?!.-_)[@]([a-zA-Z]+([.-][a-zA-Z]+)+)";
            MatchCollection matchingEmails = Regex.Matches(data, emailPattern);

            foreach (var email in matchingEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}