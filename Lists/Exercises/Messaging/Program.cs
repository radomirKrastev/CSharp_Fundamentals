namespace Messaging
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<int> dataNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string message = Console.ReadLine();
            string outputString = null;
            for (int i = 0; i < dataNumbers.Count; i++)
            {
                string listElement = dataNumbers[i].ToString();
                int digitsSum = 0;
                for (int j = 0; j < listElement.Length; j++)
                {
                    char elementDigit = listElement[j];
                    string digitAsString = elementDigit.ToString();
                    digitsSum += int.Parse(digitAsString);
                }

                char symbolToConcatenate;

                int index = 0;
                for (int k = 0; k < digitsSum; k++)
                {
                    index++;
                    if (index == message.Length)
                    {
                        index = 0;
                    }
                }
                symbolToConcatenate = message[index];
                message = message.Remove(index, 1);
                outputString += symbolToConcatenate;
            }
            Console.WriteLine(outputString);

            // This is some message for you
            // 0123456789112345678921234567
            // Tis is some message for you
            // 012345678911234567892123456
        }
    }
}
