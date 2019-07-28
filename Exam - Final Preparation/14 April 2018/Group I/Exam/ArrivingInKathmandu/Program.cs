namespace ArrivingInKathmandu
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var message = Console.ReadLine();
            var pattern = @"^(?<peakName>[A-Za-z0-9\!\@\#\$\?]+)=(?<length>[0-9]+)<<(?<geohash>.+)";

            while(message!="Last note")
            {
                if (Regex.IsMatch(message, pattern))
                {
                    var data = Regex.Match(message, pattern);
                    var peakName = data.Groups["peakName"].Value;
                    var length = int.Parse(data.Groups["length"].Value);
                    var geohashCode = data.Groups["geohash"].Value;

                    if (geohashCode.Length == length)
                    {
                        peakName = Regex.Replace(peakName, @"[^\\A-Za-z0-9]", string.Empty);
                        Console.WriteLine($"Coordinates found! {peakName} -> {geohashCode}");
                    }

                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }

                else
                {
                    Console.WriteLine("Nothing found!");
                }

                message = Console.ReadLine();
            }
        }
    }
}
