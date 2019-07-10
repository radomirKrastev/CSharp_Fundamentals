namespace LongerLine
{
    using System;
    public class Program
    {
        public static void Main()
        {
            double firstLinePointX1 = double.Parse(Console.ReadLine());
            double firstLinePointY1 = double.Parse(Console.ReadLine());
            double firstLinePointX2 = double.Parse(Console.ReadLine());
            double firstLinePointY2 = double.Parse(Console.ReadLine());
            double secondLinePointX1 = double.Parse(Console.ReadLine());
            double secondLinePointY1 = double.Parse(Console.ReadLine());
            double secondLinePointX2 = double.Parse(Console.ReadLine());
            double secondLinePointY2 = double.Parse(Console.ReadLine());

            if (GetLineLength(firstLinePointX1,firstLinePointY1,firstLinePointX2,firstLinePointY2) 
                > GetLineLength(secondLinePointX1,secondLinePointY1,secondLinePointX2,secondLinePointY2))
            {
                PrintLinePoints(firstLinePointX1, firstLinePointY1, firstLinePointX2, firstLinePointY2);
            }
            else
            {
                PrintLinePoints(secondLinePointX1, secondLinePointY1, secondLinePointX2, secondLinePointY2);
            }
        }

        public static void PrintLinePoints(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Abs(x1) + Math.Abs(y1);
            double secondPoint = Math.Abs(x2) + Math.Abs(y2);

            if (firstPoint <= secondPoint)
            {
                Console.WriteLine("(" + x1 + ", " + y1 + ")"+ "(" + x2 + ", " + y2 + ")");
            }
            else
            {
                Console.WriteLine("(" + x2 + ", " + y2 + ")"+ "(" + x1 + ", " + y1 + ")");
            }
        }

        public static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double firstLength = Math.Abs(x1) + Math.Abs(y1);
            double secondLength = Math.Abs(x2) + Math.Abs(y2);
            //double firstLength = Math.Abs(x1 - y1);
            //double secondLength = Math.Abs(x2 - y2);

            double result = secondLength + secondLength;
            return result;
        }


    }
}
