namespace MultiplicationSign
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int negativeNumbersCount = 0;
            bool isResultZero=false;
            for (int i = 0; i < 3; i++)
            {
                double dataNumber = double.Parse(Console.ReadLine());
                if (dataNumber == 0)
                {
                    isResultZero = true;
                    break;
                }
                else if (dataNumber < 0)
                {
                    negativeNumbersCount++;
                }
            }
            
            if (isResultZero)
            {
                Console.WriteLine("zero");
            }
            else if (negativeNumbersCount==1||negativeNumbersCount==3)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }

        }
    }
}
