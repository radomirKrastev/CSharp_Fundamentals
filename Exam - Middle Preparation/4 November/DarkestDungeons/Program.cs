namespace DarkestDungeons
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var health = 100d;
            var coins = 0d;

            var dungeonRooms = Console.ReadLine().Split('|');
            var bestRoom = 0;
            foreach (var room in dungeonRooms)
            {
                bestRoom++;
                var currentRoom = room.Split();
                if (currentRoom[0] == "potion")
                {
                    var healing = double.Parse(currentRoom[1]);
                    if (health + healing <= 100)
                    {
                        health += healing;
                        Console.WriteLine($"You healed for {healing} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                    else
                    {
                        healing = 100 - health;
                        health = 100;
                        Console.WriteLine($"You healed for {healing} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }

                else if (currentRoom[0] == "chest")
                {
                    var coinsFound = double.Parse(currentRoom[1]);
                    coins += coinsFound;
                    Console.WriteLine($"You found {coinsFound} coins.");
                }

                else
                {
                    var monster = currentRoom[0];
                    var damage = double.Parse(currentRoom[1]);
                    health -= damage;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");

                    }

                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        break;
                    }
                }
            }

            if (health>0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
