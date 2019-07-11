namespace Furniture
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var regex = @">>(?<product>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
            var input = Console.ReadLine();
            var purchases = string.Empty;
            var totalSum = 0.0;
            while (input != "Purchase")
            {
                purchases += input;
                input = Console.ReadLine();
            }

            MatchCollection validPurchases = Regex.Matches(purchases, regex);

            Console.WriteLine("Bought furniture:");

            foreach (Match purchase in validPurchases)
            {
                var product = purchase.Groups["product"].Value;
                var price = double.Parse(purchase.Groups["price"].Value);
                var quantity = int.Parse(purchase.Groups["quantity"].Value);
                totalSum += price*quantity;
                Console.WriteLine(product);
            }

            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
