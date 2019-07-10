
namespace PalindromeIntegers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            while(command != "END")
            {
                int data = int.Parse(command);
                Console.WriteLine(GetsPolindromeResult(data));
                command = Console.ReadLine();
            }
            
        }

        public static string GetsPolindromeResult (int data)
        {
            string result = "true";
            for (int i = 0; i < TurnsDataToArray(data).Length; i++)
            {
                if (GetsDataReversed(data)[i] != TurnsDataToArray(data)[i])
                {
                    return result = "false";
                }
            }
            return result;
        }

        public static int[] GetsDataReversed(int data)
        {
            int[] numberAsArrayReversed = new int[TurnsDataToArray(data).Length];

            for (int i = 0; i < TurnsDataToArray(data).Length; i++)
            {
                numberAsArrayReversed[i] = TurnsDataToArray(data)[i];
            }

            Array.Reverse(numberAsArrayReversed);
            return numberAsArrayReversed;
        }

        public static int[] TurnsDataToArray(int data)
        {
            int[] dataAsArray = new int[data.ToString().Length];

            for (int i = 0; i < data.ToString().Length; i++)
            {
                char numeralAsChar = data.ToString()[i];
                string numeralAsString = "" + numeralAsChar;

                dataAsArray[i] = int.Parse(numeralAsString);
            }

            return dataAsArray;

        }

    }
}
