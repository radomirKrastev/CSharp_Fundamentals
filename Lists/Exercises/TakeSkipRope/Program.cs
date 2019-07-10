namespace TakeSkipRope
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            string encryptedMessage = Console.ReadLine();

            List<string> noNumbers = new List<string>();
            List<int> numbers = new List<int>();

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char symbol = encryptedMessage[i];
                string messageElement = symbol.ToString();

                if (int.TryParse(messageElement, out int n))
                {
                    numbers.Add(n);
                }
                else
                {
                    noNumbers.Add(messageElement);
                }

            }

            List<int> takeNumbers = new List<int>();
            List<int> skipNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeNumbers.Add(numbers[i]);
                }
                else
                {
                    skipNumbers.Add(numbers[i]);
                }
            }

            List<string> decryptedMessage = new List<string>();
            int counter = 0;
            int skipCount = 0;
            int takeCount = 0;

            for (int i = 0; i < noNumbers.Count; i += skipCount)
            {
                takeCount = takeNumbers[counter];
                skipCount = skipNumbers[counter];
                if (i+takeCount >= noNumbers.Count)
                {
                    takeCount += (noNumbers.Count - (i + takeCount));
                }

                for (int j = 0; j < takeCount; j++)
                {
                    decryptedMessage.Add(noNumbers[i+j]);
                }
                skipCount += takeNumbers[counter];
                counter++;
                if (counter == skipNumbers.Count)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join("",decryptedMessage));

        }
    }
}
