namespace ProblemThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var shopsList = Console.ReadLine().Split(" ").ToList();
            var commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "Include")
                {
                    var shop = command[1];
                    shopsList.Add(shop);
                }

                else if(command[0]== "Visit")
                {
                    var shopsToVisit = int.Parse(command[2]);
                    if (shopsToVisit <= shopsList.Count)
                    {
                        if (command[1] == "first")
                        {
                            shopsList.RemoveRange(0, shopsToVisit);
                        }

                        else
                        {
                            var index = shopsList.Count - shopsToVisit;
                            shopsList.RemoveRange(index, shopsToVisit);
                        }
                    }
                }

                else if (command[0] == "Prefer")
                {
                    var firstIndex = int.Parse(command[1]);
                    var secondIndex = int.Parse(command[2]);

                    if (firstIndex >= 0 && firstIndex < shopsList.Count
                        && secondIndex >= 0 && secondIndex < shopsList.Count)
                    {
                        var firstIndexShop = shopsList[firstIndex];
                        var secondIndexShop = shopsList[secondIndex];

                        shopsList[firstIndex] = secondIndexShop;
                        shopsList[secondIndex] = firstIndexShop;
                    }
                }

                else
                {
                    var shop = command[1];
                    var index = int.Parse(command[2]);

                    if (index+1 >= 0 && index+1 < shopsList.Count)
                    {
                        shopsList.Insert(index + 1, shop);
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shopsList));


        }
    }
}
