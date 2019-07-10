
namespace WaterTank
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int countOfFillings = int.Parse(Console.ReadLine());

            int capacityLeft = 255;
            for (int i = 1; i <= countOfFillings; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());
                if (litersOfWater > capacityLeft)
                {
                    Console.WriteLine("Insufficient capacity!");

                }
                else
                {
                    capacityLeft -= litersOfWater;
                }

            }

            Console.WriteLine(255-capacityLeft);
        }
    }
}
