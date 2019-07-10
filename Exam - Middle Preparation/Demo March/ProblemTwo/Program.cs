namespace ProblemTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var breadsQuality = Console.ReadLine();
            var highestQuality = int.MinValue;
            var highestAverageQuality = double.MinValue;
            var fewestElements = int.MaxValue;
            var bestBatch = new List<int>();

            while(breadsQuality!="Bake It!")
            {

                var breadsBatch = breadsQuality.Split("#").Select(int.Parse).ToList();

                if (breadsBatch.Sum() > highestQuality)
                {
                    highestQuality = breadsBatch.Sum();
                    highestAverageQuality = breadsBatch.Average();
                    fewestElements = breadsBatch.Count;
                    bestBatch = breadsBatch;
                }

                else if (breadsBatch.Sum() == highestQuality)
                {
                    if (breadsBatch.Average() > highestAverageQuality)
                    {
                        highestQuality = breadsBatch.Sum();
                        highestAverageQuality = breadsBatch.Average();
                        fewestElements = breadsBatch.Count;
                        bestBatch = breadsBatch;
                    }

                    else if (breadsBatch.Average() == highestAverageQuality)
                    {
                        if (breadsBatch.Count < fewestElements)
                        {
                            highestQuality = breadsBatch.Sum();
                            highestAverageQuality = breadsBatch.Average();
                            fewestElements = breadsBatch.Count;
                            bestBatch = breadsBatch;
                        }
                    }
                }

                breadsQuality = Console.ReadLine();
            }

            Console.WriteLine($"Best Batch quality: {highestQuality}");
            Console.WriteLine(string.Join(" ", bestBatch));
        }
    }
}
