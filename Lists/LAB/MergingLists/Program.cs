namespace MergingLists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int smallestList = Math.Min(firstList.Count, secondList.Count);
            List<int> combinedList = new List<int>();
            for (int i = 0; i < smallestList; i++)
            {
                combinedList.Add(firstList[i]);
                combinedList.Add(secondList[i]);
            }

            List <int> biggerList  = new List<int>();
            if (smallestList == firstList.Count)
            {
                biggerList = secondList;
            }
            else
            {
                biggerList = firstList;
            }

            for (int i = smallestList; i < biggerList.Count; i++)
            {
                combinedList.Add(biggerList[i]);
            }

            Console.WriteLine(string.Join(" ", combinedList));

        }
    }
}
