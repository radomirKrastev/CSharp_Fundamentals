namespace HouseParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int countOfCommands = int.Parse(Console.ReadLine());
            List <string> namesList = new List<string>();
            for (int i = 0; i < countOfCommands; i++)
            {
                List<string> nameAndStatus = Console.ReadLine().Split().ToList();
                if (nameAndStatus.Count == 3)
                {
                    if (namesList.Contains(nameAndStatus[0]))
                    {
                        Console.WriteLine(nameAndStatus[0] + " is already in the list!");
                    }
                    else
                    {
                        namesList.Add(nameAndStatus[0]);
                    }
                }
                else
                {
                    if (namesList.Contains(nameAndStatus[0]))
                    {
                        namesList.Remove(nameAndStatus[0]);
                    }
                    else
                    {
                        Console.WriteLine(nameAndStatus[0]+" is not in the list!");
                    }
                }
            }

            for (int i = 0; i < namesList.Count; i++)
            {
                Console.WriteLine(namesList[i]);
            }
        }
    }
}
