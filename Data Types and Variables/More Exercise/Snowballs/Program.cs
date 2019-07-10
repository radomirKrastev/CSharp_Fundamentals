using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutOfSnowballs = int.Parse(Console.ReadLine());

            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            double snowballValue = double.MinValue;
            for (int i = 0; i<coutOfSnowballs; i++)
            {
                for (int j =0; j<1; j++)
                {
                    int snowballSnow = int.Parse(Console.ReadLine());
                    for (int k = 0; k < 1; k++)
                    {
                        int snowballTime = int.Parse(Console.ReadLine());
                        for (int l = 0; l < 1; l++)
                        {
                            int snowballQuality = int.Parse(Console.ReadLine());

                            BigInteger result = new BigInteger(); Math.Pow((snowballSnow / snowballTime),snowballQuality);
                            if (snowballValue < result)
                            {
                                bestSnowballSnow = snowballSnow;
                                bestSnowballTime = snowballTime;
                                bestSnowballQuality = snowballQuality;
                                snowballValue = result;
                            }

                        }
                    }


                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {snowballValue} ({bestSnowballQuality})");

        }
    }
}
