namespace CountRealNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!count.ContainsKey(number))
                {
                    count[number] = 0;
                }

                count[number]++;
            }

            foreach (var kvp in count)
            {
                Console.WriteLine(kvp.Key+" -> "+kvp.Value);
            }
        }
    }
}
