namespace BeerKegs
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int countOfKegs = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string biggestKegModel = null;
            for (int i = 1; i <= countOfKegs; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double heigth = double.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * heigth;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKegModel = modelOfKeg;
                }
            }
            Console.WriteLine(biggestKegModel);
        }
    }
}
