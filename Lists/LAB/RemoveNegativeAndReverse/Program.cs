namespace RemoveNegativeAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            List<int> dataNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0)
                .ToList();

            if (dataNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                dataNumbers.Reverse();
                Console.WriteLine(string.Join(" ", dataNumbers));
            }
            

        }
    }
}
