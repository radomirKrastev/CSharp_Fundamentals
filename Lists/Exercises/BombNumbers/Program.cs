namespace BombNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<int> dataNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numberAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bombNumber = numberAndPower[0];
            int bombPower = numberAndPower[1];

            while (dataNumbers.Contains(bombNumber))
            {
                int bombIndex = dataNumbers.IndexOf(bombNumber);
                dataNumbers = BombTheNumbers(dataNumbers, bombPower, bombIndex);
            }

            int numbersLeftSum = GetTheSum(dataNumbers);
            Console.WriteLine(numbersLeftSum);

        }

        public static int GetTheSum(List<int> dataNumbers)
        {

            int sum = 0;
            if (dataNumbers.Count > 1)
            {
                sum = dataNumbers[0];
                for (int i = 1; i < dataNumbers.Count; i++)
                {
                    sum += dataNumbers[i];
                }
            }
            

            return sum;
        }

        public static List<int> BombTheNumbers (List<int> dataNumbers, int bombPower, int bombIndex)
        {
            for (int i = 0; i < bombPower; i++)
            {
                if (bombIndex > 0)
                {
                    dataNumbers.RemoveAt(bombIndex - 1);
                    bombIndex--;
                }
                else
                {
                    break;
                }
                
            }

            for (int i = 0; i < bombPower; i++)
            {
                if (bombIndex < dataNumbers.Count - 1)
                {
                    dataNumbers.RemoveAt(bombIndex + 1);
                }
                else
                {
                    break;
                }
                
            }

            dataNumbers.RemoveAt(bombIndex);
            return dataNumbers;
        }
    }
}
