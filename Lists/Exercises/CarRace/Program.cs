namespace CarRace
{
    using System;
    using System.Linq;
    
    public class Program
    {
        public static void Main()
        {
            int[] checkpointTime = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double firstCarTime = 0;
            for (int i = 0; i < checkpointTime.Length/2; i++)
            {
                if (checkpointTime[i] == 0)
                {
                    firstCarTime *= 0.8;
                }
                else
                {
                    firstCarTime += checkpointTime[i];
                }
            }

            double secondCarTime = 0;
            for (int i = checkpointTime.Length-1; i > checkpointTime.Length/2; i--)
            {
                if (checkpointTime[i] == 0)
                {
                    secondCarTime *= 0.8;
                }
                else
                {
                    secondCarTime += checkpointTime[i];
                }
            }

            double winnerTime = Math.Min(firstCarTime, secondCarTime);
            string winnerSide;
            if (winnerTime == firstCarTime)
            {
                winnerSide = "left";
            }
            else
            {
                winnerSide = "right";
            }
            Console.WriteLine($"The winner is {winnerSide} with total time: {winnerTime}");
        }
    }
}
