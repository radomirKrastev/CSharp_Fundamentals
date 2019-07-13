namespace SoftUniBar
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"%(?<customer>[A-Z]{1}[a-z]{2,})%[^\$%|]*<(?<product>\w+)>[^\$%|]*[|](?<quantity>[1-9]+[0-9]*)[|][^\$%|\d-]*(?<price>[1-9]+[.0-9]*)[$]";
            var orders = string.Empty;
            var totalIncome = 0.0;

            while (input != "end of shift")
            {
                orders += input;
                input = Console.ReadLine();
            }

            MatchCollection matchingOrders = Regex.Matches(orders, pattern);

            foreach (Match order in matchingOrders)
            {
                string test = order.Groups["quantity"].Value;
                var quantity = int.Parse(order.Groups["quantity"].Value);
                var price = double.Parse(order.Groups["price"].Value);
                var customerBill = quantity * price;
                totalIncome += customerBill;
                Console.WriteLine($"{order.Groups["customer"].Value}: {order.Groups["product"].Value} - {customerBill:F2}");
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
