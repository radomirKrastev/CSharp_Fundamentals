
namespace NxNMatrix
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int factor = int.Parse(Console.ReadLine());
            PrintsTheMatrix(factor);
        }

        public static void PrintsTheMatrix (int factor)
        {
            for (int i = 0; i < factor; i++)
            {
                for (int j = 0; j < factor; j++)
                {
                    Console.Write(factor+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
