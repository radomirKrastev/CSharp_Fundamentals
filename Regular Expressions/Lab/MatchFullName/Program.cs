namespace MatchFullName
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            string regex = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";
            string names = Console.ReadLine();

            MatchCollection namesMatched = Regex.Matches(names, regex);

            foreach (Match name in namesMatched)
            {
                Console.Write(name.Value+" ");
            }
        }
    }
}
