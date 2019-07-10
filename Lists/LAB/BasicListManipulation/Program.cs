namespace BasicListManipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            List<int> dataNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string [] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "end")
            {
               dataNumbers = GetManipulatedList(dataNumbers, command); 
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ",dataNumbers));
        }

        public static List<int> GetManipulatedList (List<int> dataNumbers,string [] command)
        {
            if (command[0] == "Add")
            {
                dataNumbers.Add(int.Parse(command[1]));
            }
            else if (command[0] == "Remove")
            {
                dataNumbers.Remove(int.Parse(command[1]));
            }
            else if (command[0] == "RemoveAt")
            {
                dataNumbers.RemoveAt(int.Parse(command[1]));
            }
            else if (command[0] == "Insert")
            {
                dataNumbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
            }

            return dataNumbers;
        }
    }
}
