namespace ProblemThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                if (command[0] == "Change")
                {
                    var paintNumber = int.Parse(command[1]);
                    var newNumber = int.Parse(command[2]);

                    if (numbersList.Contains(paintNumber))
                    {
                        var index = numbersList.IndexOf(paintNumber);
                        numbersList[index] = newNumber;
                    }
                }

                else if (command[0] == "Hide")
                {
                    var numberToHide = int.Parse(command[1]);

                    while (numbersList.Contains(numberToHide))
                    {
                        numbersList.Remove(numberToHide);
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

                    if(index>=0 && index + 1 <= numbersList.Count)
                    {
                        numbersList.Insert(index+1, number);
                    }
                }

                else
                {
                    numbersList.Reverse();
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ",numbersList));

        }
    }
}
