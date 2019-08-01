namespace VaporWinterSale
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var games = new Dictionary<string, Game>();

            foreach (var data in input)
            {
                var game = new Game();
                var gameInfo = new List<string>();
                if (data.Contains('-'))
                {
                    gameInfo = data.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var name = gameInfo[0];
                    var price = double.Parse(gameInfo[1]);
                    game.Price = price;
                    games.Add(name, game);
                }

                else
                {
                    gameInfo = data.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var name = gameInfo[0];
                    var addition = gameInfo[1];
                    if (games.ContainsKey(name))
                    {
                        games[name].DLC = addition;
                        games[name].Price += games[name].Price * 0.2;
                    }
                }
            }

            foreach (var game in games)
            {
                if (game.Value.DLC == null)
                {
                    game.Value.Price -= game.Value.Price * 0.2;
                }

                else
                {
                    game.Value.Price -= game.Value.Price * 0.5;
                }
            }

            foreach (var game in games.OrderBy(x=>x.Value.Price))
            {
                if (game.Value.DLC != null)
                {
                    Console.WriteLine($"{game.Key} - {game.Value.DLC} - {game.Value.Price:F2}");
                }
            }

            foreach (var game in games.OrderByDescending(x => x.Value.Price))
            {
                if (game.Value.DLC == null)
                {
                    Console.WriteLine($"{game.Key} - {game.Value.Price:F2}");
                }
            }
        }
    }
}
