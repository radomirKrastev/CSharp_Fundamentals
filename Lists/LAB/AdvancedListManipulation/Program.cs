namespace AdvancedListManipulation
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        static void Main()
        {
            List<double> dataNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            int countOfChanges = 0;
            while (command[0] != "end")
            {
                if (DoesCommandChangeTheList(command) == true)
                {
                    dataNumbers = GetManipulatedList(dataNumbers, command);
                    countOfChanges++;
                }
                else
                {
                    PrintResult(dataNumbers, command);
                }
                
                command = Console.ReadLine().Split().ToList();
            }

            if (countOfChanges > 0)
            {
                Console.WriteLine(string.Join(" ",dataNumbers));
            }
        }

        public static bool DoesCommandChangeTheList(List<string> command)
        {
            bool commandChangeList = command[0] == "Add" || command[0] == "Remove" || command[0] == "RemoveAt"
                || command[0] == "Insert";
            return commandChangeList;
        }

        public static List<double> GetManipulatedList(List<double> dataNumbers, List<string> command)
        {
            if (command[0] == "Add")
            {
                dataNumbers.Add(double.Parse(command[1]));
            }
            else if (command[0] == "Remove")
            {
                dataNumbers.Remove(double.Parse(command[1]));
            }
            else if (command[0] == "RemoveAt")
            {
                dataNumbers.RemoveAt(int.Parse(command[1]));
            }
            else if (command[0] == "Insert")
            {
                dataNumbers.Insert(int.Parse(command[2]), double.Parse(command[1]));
            }

            return dataNumbers;
        }

        public static void PrintResult (List<double> dataNumbers,List<string> command)
        {
            if (command[0] == "Contains")
            {
                Console.WriteLine(string.Join(" ", GetContainMessage(dataNumbers, command))); 
            }

            else if (command[0] == "PrintEven")
            {
                Console.WriteLine(string.Join(" ", dataNumbers.Where(x => x % 2 == 0)));
            }

            else if (command[0] == "PrintOdd")
            {
                Console.WriteLine(string.Join(" ", dataNumbers.Where(x => x % 2 != 0)));
            }

            else if (command[0] == "GetSum")
            {
                Console.WriteLine(GetListSum(dataNumbers));
            }

            else if (command[0] == "Filter")
            {
                Console.WriteLine(string.Join(" ",GetFilteredList(dataNumbers, command))); 
            }
        }

        public static string GetContainMessage (List<double>dataNumbers,List<string> command)
        {
            string message = "No such number";
            if (dataNumbers.Contains(double.Parse(command[1])))
            {
                message ="Yes";
            }

            return message;
        }

        public static double GetListSum(List<double> dataNumbers)
        {
            double sum = dataNumbers[0];
            for (int i = 1; i < dataNumbers.Count; i++)
            {
                sum += dataNumbers[i];
            }

            return sum;
        }

        public static List<double> GetFilteredList (List<double> dataNumbers, List<string> command)
        {
            List<double> filteredList = new List<double>();
            if (command[1] == "<")
            {
                double filterBorder = double.Parse(command[2]);
                filteredList = dataNumbers.Where(x => x < filterBorder).ToList();
                //Console.WriteLine(string.Join(" ", filteredList));
            }
            else if (command[1] == ">")
            {
                double filterBorder = double.Parse(command[2]);
                filteredList = dataNumbers.Where(x => x > filterBorder).ToList();
                //Console.WriteLine(string.Join(" ", filteredList));
            }
            else if (command[1] == "<=")
            {
                double filterBorder = double.Parse(command[2]);
                filteredList = dataNumbers.Where(x => x <= filterBorder).ToList();
                //Console.WriteLine(string.Join(" ", filteredList));
            }
            else
            {
                double filterBorder = double.Parse(command[2]);
                filteredList = dataNumbers.Where(x => x >= filterBorder).ToList();
                //Console.WriteLine(string.Join(" ", filteredList));
            }

            return filteredList;
        }
    }
}
