namespace Deciphering
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var encodedMessage = Console.ReadLine();
            var keys = Console.ReadLine().Split();
            var pattern = @"^[d-z\{\}\,\#\|]+$";
            var decodedMessage = string.Empty;
            var finalMessage = string.Empty;

            if (Regex.IsMatch(encodedMessage, pattern))
            {
                foreach (var ch in encodedMessage)
                {
                    decodedMessage += ((char)(ch - 3)).ToString();
                }

                var substringToReplace = keys[0];
                finalMessage = Regex.Replace(decodedMessage, keys[0], keys[1]);

                Console.WriteLine(finalMessage);
            }

            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
