namespace ProblemOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var wordsSequence = Console.ReadLine().Split().ToList();
            
            var command = Console.ReadLine().Split();

            while (command[0] != "Stop")
            {
                if (command[0] == "Delete")
                {
                    var index = int.Parse(command[1]);
                    if(index>=0 && index + 1 < wordsSequence.Count)
                    {
                        wordsSequence.RemoveAt(index + 1);
                    }
                }

                else if (command[0] == "Swap")
                {
                    var wordOne = command[1];
                    var wordTwo = command[2];

                    if (wordsSequence.Contains(wordOne) && wordsSequence.Contains(wordTwo))
                    {
                        var indexOne = wordsSequence.IndexOf(wordOne);
                        var indexTwo = wordsSequence.IndexOf(wordTwo);
                        wordsSequence[indexOne] = wordTwo;
                        wordsSequence[indexTwo] = wordOne;
                    }
                }

                else if (command[0] == "Put")
                {
                    var index = int.Parse(command[2]);
                    var word = command[1];
                    if (index-1>= 0 && index-1 <= wordsSequence.Count)
                    {
                        
                        wordsSequence.Insert(index-1, word);
                    }
                }

                else if (command[0] == "Sort")
                {
                    wordsSequence = wordsSequence.OrderByDescending(x => x).ToList();
                }

                else
                {
                    var newWord = command[1];
                    var oldWord = command[2];

                    if (wordsSequence.Contains(oldWord))
                    {
                        var index = wordsSequence.IndexOf(oldWord);
                        wordsSequence[index] = newWord;
                    }
                }

                //Console.WriteLine(String.Join(" ", wordsSequence));
                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(" ",wordsSequence));
        }
    }
}
