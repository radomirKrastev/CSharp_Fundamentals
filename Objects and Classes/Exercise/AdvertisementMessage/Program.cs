namespace AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var messages = int.Parse(Console.ReadLine());
            var phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new List<string>()
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            var authors = new List<string>()
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            var cities = new List<string>()
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            var randomElement = new Random();
            for (int i = 0; i < messages; i++)
            {
                var phraseIndex = randomElement.Next(0, phrases.Count);
                var eventIndex = randomElement.Next(0, events.Count);
                var authorIndex = randomElement.Next(0, authors.Count);
                var cityIndex = randomElement.Next(0, cities.Count);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[cityIndex]}");
            }

        }
    }
}
