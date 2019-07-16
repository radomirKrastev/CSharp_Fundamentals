namespace SantaSecretHelper
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var key = int.Parse(Console.ReadLine());
            var childPattern = @"(?<=@)(?<name>[A-Za-z]+)[^\-|@|:|>|!]+[!][G][!]";
            var message = Console.ReadLine();

            while (message != "end")
            {
                var decryptedMessage = string.Empty;

                foreach (var symbol in message)
                {
                    decryptedMessage += ((char)(symbol - key)).ToString();
                }

                if (Regex.IsMatch(decryptedMessage, childPattern))
                {
                    var child = Regex.Match(decryptedMessage, childPattern);
                    Console.WriteLine(child.Groups["name"].Value);
                }

                message = Console.ReadLine();
            }
        }
    }
}
