namespace StarEnigma
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var messagesCount = int.Parse(Console.ReadLine());
            var specialSymbols = @"[STARstar]";
            var planets = new Dictionary<string, List<string>>();
            planets.Add("A", new List<string>());
            planets.Add("D", new List<string>());

            for (int i = 0; i < messagesCount; i++)
            {
                var message = Console.ReadLine();
                MatchCollection keySymbols = Regex.Matches(message, specialSymbols);
                var decryptedMessage = string.Empty;

                foreach (var symbol in message)
                {
                    var newSymbol = ((char)(((int)symbol - keySymbols.Count))).ToString();
                    decryptedMessage += newSymbol;
                }

                var planetPattern = @"@(?<name>[A-Za-z]+)[^\-@!:>]*:(?<population>[1-9]{1}[0-9]*)[^\-@!:>]*!(?<type>[A|D])![^\-@!:>]*->(?<soldiers>[1-9]{1}[0-9]*)";

                if (Regex.IsMatch(decryptedMessage, planetPattern))
                {
                    Match matchingPlanet = Regex.Match(decryptedMessage, planetPattern);
                    if (matchingPlanet.Groups["type"].Value == "A")
                    {
                        planets["A"].Add(matchingPlanet.Groups["name"].Value);
                    }

                    else
                    {
                        planets["D"].Add(matchingPlanet.Groups["name"].Value);
                    }
                }
            }

            foreach (var planet in planets.OrderBy(x=>x.Key))
            {
                if (planet.Key == "A")
                {
                    Console.WriteLine($"Attacked planets: {planet.Value.Count()}");
                    if (planet.Value.Count() > 0)
                    {
                        Console.WriteLine("-> " + string.Join(Environment.NewLine + "-> ", planet.Value.OrderBy(x=>x)));
                    }                    
                }

                else
                {
                    Console.WriteLine($"Destroyed planets: {planet.Value.Count()}");
                    if (planet.Value.Count() > 0)
                    {
                        Console.WriteLine("-> " + string.Join(Environment.NewLine + "-> ", planet.Value.OrderBy(x=>x)));
                    }
                }
            }
        }
    }
}
