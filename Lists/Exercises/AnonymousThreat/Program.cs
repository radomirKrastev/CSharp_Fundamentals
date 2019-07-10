namespace AnonymousThreat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Program
    {
        public static void Main()
        {
            List<string> data = Console.ReadLine().Split().ToList();

            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    data = GetMergedList(data, command);
                }
                else if (command[0] == "divide")
                {
                    data = GetDividedList(data, command);
                }
                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", data));

        }

        public static List<string> GetDividedList(List<string> data, List<string> command)
        {
            int indexOfStr = int.Parse(command[1]);
            int partitions = int.Parse(command[2]);
            StringBuilder element = new StringBuilder(data[indexOfStr]);

            List<string> substringsList = new List<string>();
            int countOfSymbolsPerSubstr;
            int stringLength = data[indexOfStr].Length;

                countOfSymbolsPerSubstr = stringLength / partitions;

                for (int i = 0; i < partitions - 1; i++)
                {
                    string substring = "";
                    for (int j = 0; j < countOfSymbolsPerSubstr; j++)
                    {
                        substring += element[0];
                        element.Remove(0, 1);
                    }
                    substringsList.Add(substring);
                }

                substringsList.Add(element.ToString());

            data.RemoveAt(indexOfStr);
            data.InsertRange(indexOfStr, substringsList);
            return data;
        }

        public static List<string> GetMergedList(List<string> data, List<string> command)
        {
            int startIndex = int.Parse(command[1]);
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            else if (startIndex > data.Count - 1)
            {
                startIndex = data.Count - 1;
            }

            int endIndex = int.Parse(command[2]);
            if (endIndex < 0)
            {
                endIndex = 0;
            }

            else if (endIndex > data.Count - 1)
            {
                endIndex = data.Count - 1;
            }

            int mergeRange = endIndex - startIndex;
            for (int i = 0; i < mergeRange; i++)
            {
                data[startIndex] += data[startIndex + 1];
                data.RemoveAt(startIndex + 1);
            }

            return data;
        }
    }
}
