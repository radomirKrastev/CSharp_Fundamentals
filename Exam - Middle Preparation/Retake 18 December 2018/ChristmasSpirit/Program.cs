namespace ChristmasSpirit
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var quantity = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var christmasSpirit = 0;
            var decorationCost = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }

                if (i % 2 == 0)
                {
                    christmasSpirit += 5;
                    decorationCost += quantity * 2;
                }

                if (i % 3 == 0)
                {
                    christmasSpirit += 13;
                    decorationCost += (8) * quantity;
                }

                if (i % 5 == 0)
                {
                    christmasSpirit += 17;
                    decorationCost += 15 * quantity;

                    if (i % 3 == 0)
                    {
                        christmasSpirit += 30;
                    }
                }

                if (i % 10 == 0)
                {
                    decorationCost += 23;
                    christmasSpirit -= 20;
                }
                                
            }

            if (days % 10 == 0)
            {
                christmasSpirit -= 30;
            }

            Console.WriteLine($"Total cost: {decorationCost}");
            Console.WriteLine($"Total spirit: {christmasSpirit}");
        }
    }
}
