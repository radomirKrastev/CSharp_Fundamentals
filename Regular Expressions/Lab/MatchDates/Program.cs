﻿namespace MatchDates
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var regex = @"\b(?<day>\d{2})([-./])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var dates = Console.ReadLine();

            MatchCollection matchingDates = Regex.Matches(dates, regex);

            foreach (Match date in matchingDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
