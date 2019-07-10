namespace LargestThreeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbersSequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = numbersSequence.OrderByDescending(x=>x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
