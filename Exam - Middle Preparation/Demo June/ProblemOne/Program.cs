namespace ProblemOne
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var command = Console.ReadLine().Split(' ');

            while (command[0] != "END")
            {
                if (command[0] == "Change")
                {
                    var paintingNumber =int.Parse(command[1]);
                    var changeNumber =int.Parse(command[2]);

                    if (numbersList.Contains(paintingNumber))
                    {
                        var index = numbersList.IndexOf(paintingNumber);
                        numbersList[index] = changeNumber;
                    }
                }

                else if (command[0] == "Hide")
                {
                    var paintingNumber = int.Parse(command[1]);
                    while (numbersList.Contains(paintingNumber))
                    {
                        numbersList.Remove(paintingNumber);
                    }
                }

                else if (command[0] == "Switch")
                {
                    var numberOne = int.Parse(command[1]);
                    var numberTwo = int.Parse(command[2]);

                    if (numbersList.Contains(numberOne) && numbersList.Contains(numberTwo))
                    {
                        var indexOne = numbersList.IndexOf(numberOne);
                        var indexTwo = numbersList.IndexOf(numberTwo);

                        numbersList[indexOne] = numberTwo;
                        numbersList[indexTwo] = numberOne;
                    }
                }

                else if (command[0] == "Insert")
                {
                    var index = int.Parse(command[1]);
                    var number = int.Parse(command[2]);

                    if (index >= 0 && index < numbersList.Count)
                    {
                        if (index == numbersList.Count - 1)
                        {
                            numbersList.Add(number);
                        }

                        else
                        {
                            numbersList.Insert(index + 1, number);
                        }
                    }
                }

                else
                {
                    numbersList.Reverse();
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(" ", numbersList));
        }               
    }
}
