
namespace Messages
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            Console.WriteLine(GetText(countOfInputs));
            
        }

        public static string GetText(int countOfInputs)
        {
            string text = null;
            for (int i = 0; i < countOfInputs; i++)
            {
                string input = Console.ReadLine();
                int ASCINumber = GetNumberToAddTo97AsciCod(input)+97;
                char letter = (char)ASCINumber;
                text += letter;
            }
            return text;
        }

        public static int GetNumberToAddTo97AsciCod(string input)
        {
            int numberOfDigits = input.Length;
            int mainDigit = int.Parse(input[0].ToString());
            int numberToAdd = 0;
            if (mainDigit == 0)
            {
                numberToAdd = -65;
            }
            else if (mainDigit == 8 || mainDigit == 9)
            {
                numberToAdd = (mainDigit - 2) * 3 + 1 + (numberOfDigits-1);
            }
            else
            {
                numberToAdd = (mainDigit - 2) * 3 + (numberOfDigits-1);
            }

            return numberToAdd;
        }

    }
}
