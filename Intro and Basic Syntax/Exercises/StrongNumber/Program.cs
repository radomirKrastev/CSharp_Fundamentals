
namespace StrongNumber
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number == GetFactorialSum(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }

        public static int GetFactorialSum(int number)
        {
            int [] dataArray = GetDataAsArray(number);
            int factorialSum = 0;
            for (int i = 0; i < dataArray.Length; i++)
            {
                
                int currentDigitFactorial = 1;
                if (dataArray[i] != 0)
                {
                    currentDigitFactorial = dataArray[i];
                }
                for (int j = dataArray[i]-1; j > 0; j--)
                {
                    currentDigitFactorial *= j;  
                }
                factorialSum += currentDigitFactorial;
            }

            return factorialSum;
        } 
        

        public static int [] GetDataAsArray(int number)
        {
            string numberToString = number.ToString();
            int[] dataArray = new int[number.ToString().Length];

            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = int.Parse(numberToString[i].ToString());
            }
            return dataArray;
        }
    }
}
