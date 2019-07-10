namespace CenterPoint
{
    using System;
    public class Program
    {
        public static void Main()
        {
            decimal coordinatsX1 = decimal.Parse(Console.ReadLine());
            decimal coordinatsY1 = decimal.Parse(Console.ReadLine());
            decimal coordinatsX2 = decimal.Parse(Console.ReadLine());
            decimal coordinatsY2 = decimal.Parse(Console.ReadLine());

            PrintClosestPoint(coordinatsX1, coordinatsY1, coordinatsX2, coordinatsY2);
        }

        public static void PrintClosestPoint(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            decimal firstPoint = Math.Abs(x1) + Math.Abs(y1);
            decimal secondPoint = Math.Abs(x2) + Math.Abs(y2);

            if (firstPoint <= secondPoint)
            {
                Console.WriteLine("("+x1+", "+y1+")");
            }
            else
            {
                Console.WriteLine("(" + x2 + ", " + y2 + ")");
            }

        }
    }
}
