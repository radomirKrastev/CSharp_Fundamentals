namespace DrumSet
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            double moneySaved = double.Parse(Console.ReadLine());
            List<int> drumsQuality = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> usedDrumsQuality = new List<int>();
            for (int i = 0; i < drumsQuality.Count; i++)
            {
                usedDrumsQuality.Add(drumsQuality[i]);
            }

            string command = Console.ReadLine();

            while(command!="Hit it again, Gabsy!")
            {
                int damage = int.Parse(command);

                for (int i = 0; i < usedDrumsQuality.Count; i++)
                {
                    if (usedDrumsQuality[i] - damage <= 0 && moneySaved >= drumsQuality[i] * 3)
                    {
                        usedDrumsQuality[i] = drumsQuality[i];
                        moneySaved -= drumsQuality[i] * 3;
                    }
                    else
                    {
                        usedDrumsQuality[i] -= damage;
                    }
                }

                command = Console.ReadLine();
            }

            List<int> finalStatusOfDrums = new List<int>();
            for (int i = 0; i < usedDrumsQuality.Count; i++)
            {
                if (usedDrumsQuality[i] > 0)
                {
                    finalStatusOfDrums.Add(usedDrumsQuality[i]);
                }
            }

            Console.WriteLine(string.Join(" ",finalStatusOfDrums));
            Console.WriteLine($"Gabsy has {moneySaved:F2}lv.");
        }

        
    }
}
