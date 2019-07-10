namespace ProblemOne
{
    using System;
    class Program
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var flourPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var apronPrice = double.Parse(Console.ReadLine());

            double totalFlourPrice = students * flourPrice;
            int countOfFreeFlour = (int)Math.Floor((double)students / 5);
            totalFlourPrice -= (countOfFreeFlour * flourPrice);
            double totalEggsPrice = students * eggPrice*10;
            int additionalApron = (int)Math.Ceiling((double)students * 0.2);
            double totalApronPrice = (students + additionalApron) * apronPrice;

            double totalPrice = totalFlourPrice + totalEggsPrice + totalApronPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Items purchased for {totalPrice:F2}$.");
            }

            else
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"{neededMoney:F2}$ more needed.");
            }
        }
    }
}
