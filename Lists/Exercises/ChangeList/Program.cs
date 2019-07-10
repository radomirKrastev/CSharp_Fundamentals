namespace ChangeList
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
            while (command[0] != "end")
            {
                dataNumbers = GetChangedList(dataNumbers, command);
                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ",dataNumbers));
        }

        public static List <int> GetChangedList(List<int> dataNumbers, List<string> command)
        {
            if (command[0] == "Delete")
            {
                int elementToBeDeleted = int.Parse(command[1]);
                dataNumbers.RemoveAll(x => x == elementToBeDeleted);
            }
            else
            {
                int elementToBeInserted = int.Parse(command[1]);
                int toIndex = int.Parse(command[2]);
                dataNumbers.Insert(toIndex, elementToBeInserted);
            }

            return dataNumbers;
        }
    }
}
