namespace PrintingTriangle
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        public static void PrintTriangle(int number)
        {
            PrintFirstTriangleHalf(1, number);
            PrintSecondTriangleHalf(1, number);
        }

        public static void PrintFirstTriangleHalf(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= i; j++)
                {
                    Console.Write(j + " ");

                }

                Console.Write(Environment.NewLine);
            }
        }

        public static void PrintSecondTriangleHalf(int start, int end)
        {
            for (int i = end - 1; i >= start; i--)
            {
                for (int j = start; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.Write(Environment.NewLine);
            }
        }
    }
}
