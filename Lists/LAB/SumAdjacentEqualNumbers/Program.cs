namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<double> numbersSequence = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbersSequence.Count - 1; i++)
            {
                if (numbersSequence[i] == numbersSequence[i + 1])
                {
                    numbersSequence[i] *= 2;
                    numbersSequence.RemoveAt(i + 1);
                    i=-1;
                }
            }

            Console.WriteLine(string.Join(" ", numbersSequence));
        }
    }
}
