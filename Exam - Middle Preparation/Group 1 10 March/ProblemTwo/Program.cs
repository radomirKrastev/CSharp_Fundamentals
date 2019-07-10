namespace ProblemTwo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var itemsList = Console.ReadLine().Split('|').ToList();
            var budget = double.Parse(Console.ReadLine());
            double buyPrice = 0;
            var itemsNewPrices = new List<double>();

            for (int i = 0; i < itemsList.Count; i++)
            {
                var currentItems = itemsList[i].Split("->").ToList();
                var items = currentItems[0];
                var price = double.Parse(currentItems[1]);
                var goodPrice = IsPriceGood(items, price);

                if (budget >= price && goodPrice)
                {
                    budget -= price;
                    buyPrice += price;
                    price += (price * 0.4);
                    itemsNewPrices.Add(price);
                }

                else
                {
                    continue;
                }
            }

            for (int i = 0; i < itemsNewPrices.Count; i++)
            {
                if (i != itemsNewPrices.Count - 1)
                {
                    Console.Write($"{itemsNewPrices[i]:F2} ");
                }

                else
                {
                    Console.WriteLine($"{itemsNewPrices[i]:F2}");
                }
            }

            double profit = itemsNewPrices.Sum() - buyPrice;
            Console.WriteLine($"Profit: {profit:F2}");

            if ((budget + buyPrice + profit) >= 150)
            {
                Console.WriteLine("Hello, France!");
            }

            else
            {
                Console.WriteLine("Time to go.");
            }
        }

        public static bool IsPriceGood(string items, double price)
        {
            bool priceIsGood = false;

            if (items == "Clothes")
            {
                if (price <= 50)
                {
                    priceIsGood = true;
                }
            }

            else if (items == "Shoes")
            {
                if (price <= 35)
                {
                    priceIsGood = true;
                }
            }

            else if (items == "Accessories")
            {
                if (price <= 20.5)
                {
                    priceIsGood = true;
                }
            }

            return priceIsGood;
        }
    }
}
