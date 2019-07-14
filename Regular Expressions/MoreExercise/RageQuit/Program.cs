namespace RageQuit
{
    using System;
    using System.Text.RegularExpressions;
    using System.Text;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var sequencePattern = @"(?<message>[^\d]+)(?<number>\d+)";
            var sequences = Regex.Matches(input, sequencePattern);
            var result = new StringBuilder();

            foreach (Match sequence in sequences)
            {
                string message = sequence.Groups["message"].Value.ToUpper();
                int repeat = int.Parse(sequence.Groups["number"].Value);

                for (int i = 0; i < repeat; i++)
                {
                    result.Append(message);
                }
            }

            string uniqueSymbols = new String(result.ToString().Distinct().ToArray());

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
            Console.WriteLine(result);
        }
    }
}
