
namespace Orders
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintsOrderPrice(product,quantity);
        }

        public static void PrintsOrderPrice(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                     price = quantity * 1.5;
                    break;
                case "water":
                     price = quantity * 1;
                    break;
                case "coke":
                     price = quantity * 1.4;
                    break;
                case "snacks":
                     price = quantity * 2;
                    break;
            }

            Console.WriteLine($"{price:F2}");
        }

    }
}
