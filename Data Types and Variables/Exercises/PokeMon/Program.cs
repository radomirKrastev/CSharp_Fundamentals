namespace PokeMon
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int powerLeft = pokePower;
            int countOfPokes = 0;
            while (powerLeft >= distanceBetweenTargets)
            {
                if (pokePower % powerLeft == 0 && pokePower / powerLeft == 2 &&exhaustionFactor!=0)
                {
                    powerLeft /= exhaustionFactor;
                }

                if (powerLeft >= distanceBetweenTargets)
                {
                    powerLeft -= distanceBetweenTargets;
                    countOfPokes++;
                }
            }

            Console.WriteLine(powerLeft);
            Console.WriteLine(countOfPokes);
        }
        
    }
}
