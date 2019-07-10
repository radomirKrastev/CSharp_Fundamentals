namespace ProblemThree
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Switch")
                {
                    var index = int.Parse(command[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers[index] *= -1;
                    }
                }

                else if (command[0] == "Change")
                {
                    var index = int.Parse(command[1]);
                    var number = int.Parse(command[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers[index] = number;
                    }
                }

                else if (command[0] == "Sum" && command[1] == "Negative")
                {
                    var negativeSum = numbers.Where(x => x < 0).Sum();
                    Console.WriteLine(negativeSum);
                }

                else if (command[0] == "Sum" && command[1] == "Positive")
                {
                    var positiveSum = numbers.Where(x => x > 0).Sum();
                    Console.WriteLine(positiveSum);
                }

                else
                {
                    var totalSum = numbers.Sum();
                    Console.WriteLine(totalSum);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= 0)));
        }
    }
}
