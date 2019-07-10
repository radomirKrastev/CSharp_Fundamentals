namespace AppendArrays
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<string> stringOfArrays = Console.ReadLine().Split("|").ToList();
            List<int> appendedArrays = new List<int>();

            for (int i = stringOfArrays.Count-1; i >= 0; i--)
            {
                appendedArrays.AddRange(stringOfArrays[i]
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }

            Console.WriteLine(string.Join(" ", appendedArrays));

        }
    }
}
