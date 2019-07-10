
namespace TopNumber
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int numberData = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= numberData; currentNumber++)
            {
                if (IsTheNumberTop(currentNumber) == true)
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }

        public static bool IsTheNumberTop(int data)
        {
            bool areConditionsMet = false;

            if (CheckIfNumberCouldBeDivided(data) == true && CheckForOddNumber(data) == true)
            {
                areConditionsMet = true;
            }
            return areConditionsMet;
        }

        public static bool CheckForOddNumber(int data)
        {
            int[] currentNumberAsArray = TurnsCurrentNumberToArray(data);

            bool isThereOddNumber = false;
            for (int j = 0; j < currentNumberAsArray.Length; j++)
            {
                if (currentNumberAsArray[j] % 2 != 0)
                {
                    isThereOddNumber = true;
                }
            }
            return isThereOddNumber;
        }

        public static bool CheckIfNumberCouldBeDivided(int data)
        {
            int[] currentNumberAsArray = TurnsCurrentNumberToArray(data);
            int sumOfNumerals = 0;
            bool divisionToEightCheck = false;
            for (int j = 0; j < currentNumberAsArray.Length; j++)
            {
                sumOfNumerals += currentNumberAsArray[j];
                if (j + 1 == currentNumberAsArray.Length)
                {
                    if (sumOfNumerals % 8 == 0)
                    {
                        sumOfNumerals = 0;
                        divisionToEightCheck = true;
                    }
                }
            }
            return divisionToEightCheck;
        }

        public static int[] TurnsCurrentNumberToArray(int data)
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
