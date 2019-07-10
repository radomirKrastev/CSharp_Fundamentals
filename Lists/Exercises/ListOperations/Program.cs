namespace ListOperations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<int> dataNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "End")
            {
                dataNumbers = GetChangedList(dataNumbers, command);
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", dataNumbers));
        }

        public static List<int> GetChangedList(List<int> dataNumbers, List<string> command)
        {

            if (command[0] == "Add")
            {
                dataNumbers.Add(int.Parse(command[1]));
            }

            else if (command[0] == "Insert")
            {
                (int.Parse(command[2]) < dataNumbers.Count &&
                int.Parse(command[2]) >= 0))
                {
                    int index = int.Parse(command[2]);
                    int number = int.Parse(command[1]);
                    dataNumbers.Insert(index, number);
                }

            }

             

            else if (command[0] == "Remove" &&
                    (int.Parse(command[1]) < dataNumbers.Count &&
                    int.Parse(command[1]) >= 0))
            {
                dataNumbers.RemoveAt(int.Parse(command[1]));
            }
            
            else if (command[1] == "left")
            {
                for (int i = 0; i < int.Parse(command[2]); i++)
                {
                    int numberToGetLast = (dataNumbers[0]);
                    dataNumbers.RemoveAt(0);
                    dataNumbers.Add(numberToGetLast);
                }
            }

            else if (command[1] == "right")
            {
                for (int i = 0; i < int.Parse(command[2]); i++)
                {
                    int numberToGetFirst = dataNumbers[dataNumbers.Count-1];
                    dataNumbers.RemoveAt(dataNumbers.Count - 1);
                    dataNumbers.Insert(0, numberToGetFirst);
                }
            }
            return dataNumbers;
        }
    }
}
