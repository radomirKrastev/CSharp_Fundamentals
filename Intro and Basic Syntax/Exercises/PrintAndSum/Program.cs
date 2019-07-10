

namespace PrintAndSum
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
                if (i == end)
                {
                    Console.Write(i);
                    break;
                }
                else
                {
                    Console.Write(i + " ");
                }
                
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Sum: " + sum);
        }
    }
}
