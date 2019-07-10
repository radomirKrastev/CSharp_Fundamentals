namespace ProblemTwo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var contanctsList = Console.ReadLine().Split().ToList();

            var command = Console.ReadLine().Split();

            while (command.Length>1)
            {
                if (command[0] == "Add")
                {
                    var contact = command[1];
                    var index = int.Parse(command[2]);

                    if (!contanctsList.Contains(contact))
                    {
                        contanctsList.Add(contact);
                    }

                    else
                    {
                        if (index >= 0 && index < contanctsList.Count)
                        {
                            contanctsList.Insert(index, contact);
                        }
                    }
                }

                else if (command[0] == "Remove")
                {
                    var index = int.Parse(command[1]);
                    if (index >= 0 && index < contanctsList.Count)
                    {
                        contanctsList.RemoveAt(index);
                    }
                }

                else if (command[0] == "Export")
                {
                    var index = int.Parse(command[1]);
                    var count = int.Parse(command[2]);
                    var contactsToPrint = new List<string>();

                    if ((contanctsList.Count - 1) - index < count)
                    {
                        for (int i = index; i < contanctsList.Count; i++)
                        {
                            contactsToPrint.Add(contanctsList[i]);
                        }                      
                    }

                    else
                    {
                        for (int i = index; i < index+count; i++)
                        {
                            contactsToPrint.Add(contanctsList[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", contactsToPrint));
                }

                else
                {
                    if (command[1] == "Reversed")
                    {
                        contanctsList.Reverse();
                        Console.Write("Contacts: ");
                        Console.WriteLine(string.Join(" ", contanctsList));
                        break;
                    }

                    else
                    {
                        Console.Write("Contacts: ");
                        Console.WriteLine(string.Join(" ", contanctsList));
                        break;
                    }
                    
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
