namespace Orders
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var productQuantity = new Dictionary<string, int>();
            var productPrice = new Dictionary<string, decimal>();
            var input = Console.ReadLine().Split(" ").ToList();

            while (input[0] != "buy")
            {
                var product = input[0];
                var price = decimal.Parse(input[1]);
                var quantity = int.Parse(input[2]);

                if (!productPrice.ContainsKey(product))
                {
                    productQuantity[product] = 0;
                }

                productQuantity[product] += quantity;
                productPrice[product] = price;

                input = Console.ReadLine().Split(" ").ToList();
            }

            var productsList = new List<string>();
            productsList.AddRange(productPrice.Keys);
            var productCost = new Dictionary<string, decimal>();
            for (int i = 0; i < productsList.Count; i++)
            {
                string product = productsList[i];
                productCost[product] = productQuantity[product] * productPrice[product];
            }

            foreach (var kvp in productCost)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
