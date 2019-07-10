namespace RepeatStrings
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var stringsList = Console.ReadLine().Split();
            var result = string.Empty;
            foreach (var str in stringsList)
            {
                var count = str.Length;
                for (int i = 0; i < count; i++)
                {
                    result += str;
                }
            }

            Console.WriteLine(result);
        }
    }
}
