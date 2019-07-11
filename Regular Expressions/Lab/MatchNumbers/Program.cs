namespace MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?((?=\s)|$)";
            var numbers = Console.ReadLine();
            var matchingNumbers = Regex.Matches(numbers, regex);
            
            Console.WriteLine(string.Join(" ", matchingNumbers
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray()));
        }
    }
}
