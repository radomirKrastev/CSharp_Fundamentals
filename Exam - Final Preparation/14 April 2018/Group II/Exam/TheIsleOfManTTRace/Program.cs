namespace TheIsleOfManTTRace
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            bool coordinatesFound = false;
            var pattern = @"(?<name>[$][A-Za-z]+[$]|[#][A-Za-z]+[#]|[%][A-Za-z]+[%]|[*][A-Za-z]+[*]|[&][A-Za-z]+[&])=(?<length>\d+)!!(?<geohashcode>.+)";

            while (coordinatesFound == false)
            {
                var message = Console.ReadLine();
                if (Regex.IsMatch(message, pattern))
                {
                    var geohashcodeRequiredLength = int.Parse(Regex.Match(message, pattern).Groups["length"].Value.ToString());
                    var geohashcode = Regex.Match(message, pattern).Groups["geohashcode"].Value.ToString();

                    if (geohashcode.Length == geohashcodeRequiredLength)
                    {
                        var decryptedCoordinates = string.Empty;
                        foreach (var symbol in geohashcode)
                        {
                            decryptedCoordinates += ((char)(symbol + geohashcodeRequiredLength)).ToString();
                        }

                        var racerName = Regex.Match(message, pattern).Groups["name"].Value.ToString();
                        racerName = Regex.Replace(racerName,@"[%]|[#]|[$]|[*]|[&]", string.Empty);
                        Console.WriteLine($"Coordinates found! {racerName} -> {decryptedCoordinates}");
                        coordinatesFound = true;
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
            }
        }
    }
}
