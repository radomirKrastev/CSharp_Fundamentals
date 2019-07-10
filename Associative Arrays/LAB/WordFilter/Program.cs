namespace WordFilter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToList()
                .ForEach(w=>Console.WriteLine(w));
        }
    }
}
