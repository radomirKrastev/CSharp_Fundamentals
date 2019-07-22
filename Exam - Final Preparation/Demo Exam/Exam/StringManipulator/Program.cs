namespace StringManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var str = string.Empty;
            var command = Console.ReadLine().Split();


            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    str+=command[1];
                }

                else if (command[0] == "Upgrade")
                {
                    char originalSymbol = char.Parse(command[1]);
                    char replaceSymbol =  (char)(originalSymbol + 1);
                    str = str.Replace(originalSymbol, replaceSymbol);
                }

                else if (command[0] == "Print")
                {
                    Console.WriteLine(str);
                }

                else if (command[0] == "Index")
                {
                    char symbol = char.Parse(command[1]);
                    var indices = new List<int>();

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == symbol)
                        {
                            indices.Add(i);
                        }
                    }

                    if (indices.Count > 0)
                    {
                        Console.WriteLine(string.Join(" ",indices));
                    }

                    else
                    {
                        Console.WriteLine("None");
                    }
                }

                else
                {
                    var deleteStr = command[1];
                    str = Regex.Replace(str, deleteStr, string.Empty);
                }

                command = Console.ReadLine().Split();                
            }
        }
    }
}
