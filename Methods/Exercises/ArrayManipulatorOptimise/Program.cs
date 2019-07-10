namespace ArrayManipulatorOptimise
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();
            string [] command = Console.ReadLine().Split(" ").ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > data.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        data = ExchangeData(data, index);
                    }
                }

                else if (command[0] == "max")
                {
                    string value = command[1];
                    int maxOddOrEven = OddOrEven(value);
                    int maxNumber = int.MinValue;
                    int maxNumberIndex = -1;
                    bool isThereSuchNumber = false;

                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i]%2==maxOddOrEven && data[i] >= maxNumber)
                        {
                            maxNumber = data[i];
                            maxNumberIndex = i;
                            isThereSuchNumber = true;
                        }
                    }

                    if (isThereSuchNumber == true)
                    {
                        Console.WriteLine(maxNumberIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }

                else if (command[0] == "min")
                {
                    string value = command[1];
                    int minOddOrEven = OddOrEven(value);
                    int minNumber = int.MaxValue;
                    int minNumberIndex = -1;
                    bool isThereSuchNumber = false;

                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i]%2==minOddOrEven && data[i] <= minNumber)
                        {
                            minNumber = data[i];
                            minNumberIndex = i;
                            isThereSuchNumber = true;
                        }
                    }

                    if (isThereSuchNumber == true)
                    {
                        Console.WriteLine(minNumberIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }

                else if (command[0] == "first")
                {
                    string value = command[2];
                    int oddOrEven = OddOrEven(value);
                    int count = int.Parse(command[1]);

                    if (count > data.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }

                    else
                    {
                        List<int> interim = data
                        .Where(x => x % 2 == oddOrEven)
                        .ToList();

                            List<int> firstRelevantNumbers = new List<int>();

                            for (int i = 0; i < interim.Count; i++)
                            {
                                firstRelevantNumbers.Add(interim[i]);
                                count--;
                                if (count==0)
                                {
                                    break;
                                }
                            }

                            Console.WriteLine("["+string.Join(", ", firstRelevantNumbers)+"]");
                    }
                    
                }

                else
                {
                    string value = command[2];
                    int oddOrEven = OddOrEven(value);
                    int count = int.Parse(command[1]);

                    if (count > data.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }

                    else
                    {
                        List<int> interim = data
                        .Where(x => x % 2 == oddOrEven)
                        .ToList();

                            List<int> firstRelevantNumbers = new List<int>();

                            for (int i = interim.Count-1; i >= 0; i--)
                            {
                                firstRelevantNumbers.Add(interim[i]);
                                count--;
                                if (count==0)
                                {
                                    break;
                                }
                            }
                            firstRelevantNumbers.Reverse();

                            Console.WriteLine("["+string.Join(", ", firstRelevantNumbers)+"]");
                    }
                }

                command = Console.ReadLine().Split(" ").ToArray();
            }

            Console.WriteLine("[" + string.Join(", ", data) + "]");
        }
        
        public static int OddOrEven (string value)
        {
            int maxOddEven = -1;

            if (value == "even")
            {
                maxOddEven = 0;
            }
            else
            {
                maxOddEven = 1;
            }

            return maxOddEven;
        }

        public static List <int> ExchangeData (List <int> data, int index)
        {
            List<int> exchangedData = new List<int>();

            for (int i = index+1; i < data.Count; i++)
            {
                exchangedData.Add(data[i]);
            }

            for (int i = 0; i <= index; i++)
            {
                exchangedData.Add(data[i]);
            }

            return exchangedData;
        }
    }
}
