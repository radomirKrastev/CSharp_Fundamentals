namespace MixedUpLists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<int> firstLineList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondLineList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int shorterList = Math.Min(firstLineList.Count, secondLineList.Count);
            List<int> mixedUpList = MixList(firstLineList, secondLineList, shorterList);
            List<int> finalList = FilterList(firstLineList, secondLineList, shorterList, mixedUpList);

            finalList.Sort();

            Console.WriteLine(string.Join(" ",finalList));
            

        }

        public static List <int> FilterList (List<int> firstLineList
            , List<int> secondLineList
            , int shorterList
            ,List<int> mixedUpList)
        {
            int rangeStart = 0;
            int rangeEnd = 0;
            if (shorterList == secondLineList.Count)
            {
                rangeStart = firstLineList[firstLineList.Count - 2];
                rangeEnd = firstLineList[firstLineList.Count - 1];
            }
            else
            {
                rangeStart = secondLineList[1];
                rangeEnd = secondLineList[0];
            }

            List<int> finalList = new List<int>();
            for (int i = 0; i < mixedUpList.Count; i++)
            {
                if (mixedUpList[i] > Math.Min(rangeStart, rangeEnd)
                    && mixedUpList[i] < Math.Max(rangeStart, rangeEnd))
                {
                    finalList.Add(mixedUpList[i]);
                }
            }

            return finalList;

        }
        public static List <int> MixList (List<int> firstLineList, List <int> secondLineList, int shorterList)
        {

            int line1counter = 0;
            int line2counter = secondLineList.Count-1;
            List<int> mixedUpList = new List<int>();
            while (line1counter < shorterList)
            {
                mixedUpList.Add(firstLineList[line1counter]);
                line1counter++;
                mixedUpList.Add(secondLineList[line2counter]);
                line2counter--;
            }

            return mixedUpList;
        }

    }
}
