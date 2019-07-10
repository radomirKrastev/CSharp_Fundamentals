namespace GaussTrick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<decimal> dataSequence = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            List<decimal> summedSequence = new List<decimal>();
            if (dataSequence.Count % 2 == 0)
            {
                summedSequence = GetSummedListIfEven(dataSequence);
            }
            else
            {
                summedSequence = GetSummedListIfOdd(dataSequence);
            }

            Console.WriteLine(string.Join(" ",summedSequence));
        }

        public static List <decimal> GetSummedListIfEven (List<decimal> data)
        {
            List<decimal> summedSequence = new List<decimal>();
            decimal indexSum = 0;
            for (int i = 0; i < data.Count / 2; i++)
            {
                indexSum = data[i] + data[data.Count - 1 - i];
                summedSequence.Add(indexSum);
            }

            return summedSequence;
        }

        public static List <decimal> GetSummedListIfOdd (List<decimal> data)
        {
            List<decimal> summedSequence = new List<decimal>();
            decimal indexSum = 0;
            for (int i = 0; i < data.Count / 2; i++)
            {
                indexSum = data[i] + data[data.Count - 1 - i];
                summedSequence.Add(indexSum);
            }
            summedSequence.Add(data[data.Count / 2]);

            return summedSequence;
        }

    }
}
