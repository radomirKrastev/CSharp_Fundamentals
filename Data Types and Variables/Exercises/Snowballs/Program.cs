namespace Snowballs
{
    using System;
    using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            int snowballsMade = int.Parse(Console.ReadLine());
            BigInteger greatestSnowball = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            for (int i = 1; i <= snowballsMade; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue =  BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);


                if (snowballValue >= greatestSnowball)
                {
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                    greatestSnowball = snowballValue;
                }

            }

            if (snowballsMade > 0)
            {
                Console.WriteLine($"{bestSnow} : {bestTime} = {greatestSnowball} ({bestQuality})");
            }
        }
    }
}