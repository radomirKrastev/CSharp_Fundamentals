namespace TreasureFinder
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input = Console.ReadLine();

            while (input != "find")
            {
                var keyCounter = 0;
                var resultString = string.Empty;

                for(int i =0; i<input.Length; i++)
                {
                    if (keyCounter == key.Length)
                    {
                        keyCounter = 0;
                    }

                    var asciiChar = (int)input[i] - key[keyCounter];
                    resultString+=(char)(asciiChar);

                    keyCounter++;
                }

                var treasureStartIndex = resultString.IndexOf('&')+1;
                var treasureEndIndex = resultString.LastIndexOf('&');
                var coordinatesStartIndex = resultString.IndexOf('<')+1;
                var coordinatesEndIndex = resultString.IndexOf('>');
                var treasure = resultString.Substring(treasureStartIndex, treasureEndIndex - treasureStartIndex);
                var coordinates = resultString.Substring(coordinatesStartIndex, coordinatesEndIndex - coordinatesStartIndex);

                Console.WriteLine($"Found {treasure} at {coordinates}");

                input = Console.ReadLine();
            }
        }
    }
}
