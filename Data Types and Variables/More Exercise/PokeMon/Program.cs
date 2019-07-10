using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokePowerLeft = pokePower;
            int countOfPokes = 0;
            while (pokePowerLeft >= distanceBetweenTargets)
            {
                pokePowerLeft -= distanceBetweenTargets;
                countOfPokes++;

                if(pokePowerLeft == 0.5 * pokePower && pokePower%pokePowerLeft==0 && pokePowerLeft!=0 && exhaustionFactor !=0)
                {

                    pokePowerLeft /= exhaustionFactor;

                }

            }

            Console.WriteLine(pokePowerLeft);
            Console.WriteLine(countOfPokes);

        }
    }
}
