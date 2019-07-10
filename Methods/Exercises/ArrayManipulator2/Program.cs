namespace ArrayManipulator2
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                if (command.Length == 2)
                {
                    IfCommandLengthIsTwoPrintResult(data, command);
                }

                else
                {
                    IfCommandLengthIsThreePrintResult(data, command);      
                }
                command = Console.ReadLine().Split();
            }

            Console.WriteLine('['+string.Join(", ",data)+']');
        }

        public static void IfCommandLengthIsThreePrintResult(int []data, string [] command)
        {
            if (command[0] == "first" && command[2] == "odd")
            {
                int countOfNumbers = int.Parse(command[1]);
                if (countOfNumbers > data.Length)
                {
                    Console.WriteLine("Invalid count");
                }

                else
                {
                    if (GetFirstNOddNumbers(data, countOfNumbers) == null)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine("["+string.Join(", ",GetFirstNOddNumbers(data, countOfNumbers))+"]");
                    }                    
                }                    
            }

            else if (command[0] == "last" && command[2] == "odd")
            {
                int countOfNumbers = int.Parse(command[1]);
                if (countOfNumbers > data.Length)
                {
                    Console.WriteLine("Invalid count");
                }

                else
                {
                    if (GetLastNOddNumbers(data, countOfNumbers) == null)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine("["+string.Join(", ",GetLastNOddNumbers(data, countOfNumbers))+"]");

                    }
                }    
            }

            else if (command[0] == "first" && command[2] == "even")
            {
                int countOfNumbers = int.Parse(command[1]);
                if (countOfNumbers > data.Length)
                {
                    Console.WriteLine("Invalid count");
                }

                else
                {
                    if (GetFirstNEvenNumbers(data, countOfNumbers) == null)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine("["+string.Join(", ",GetFirstNEvenNumbers(data, countOfNumbers))+"]");

                    }
                }    
            }

            else
            {
                int countOfNumbers = int.Parse(command[1]);
                if (countOfNumbers > data.Length)
                {
                    Console.WriteLine("Invalid count");
                }

                else
                {
                    if (GetLastNEvenNumbers(data, countOfNumbers) == null)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine("["+string.Join(", ",GetLastNEvenNumbers(data, countOfNumbers))+"]");
                    }
                }
            }

        }

        public static void IfCommandLengthIsTwoPrintResult(int[] data, string[] command)
        {
            if (command[0] == "exchange")
            {
                int exchangeIndex = int.Parse(command[1]);

                if (exchangeIndex >= 0 && exchangeIndex <= data.Length - 1)
                {
                    data = GetExchangedArray(data, exchangeIndex);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }

            else if (command[0] == "max" && command[1] == "odd")
            {
                if (GetMaxOddPosition(data) != -1)
                {
                    Console.WriteLine(GetMaxOddPosition(data));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }

            else if (command[0] == "max" && command[1] == "even")
            {
                if (GetMaxEvenPosition(data) != -1)
                {
                    Console.WriteLine(GetMaxEvenPosition(data));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }

            else if (command[0] == "min" && command[1] == "odd")
            {
                if (GetMinOddPosition(data) != -1)
                {
                    Console.WriteLine(GetMinOddPosition(data));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }

            else if (command[0] == "min" && command[1] == "even")
            {
                if (GetMinEvenPosition(data) != -1)
                {
                    Console.WriteLine(GetMinEvenPosition(data));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        public static int[] GetLastNEvenNumbers(int[] data, int countOfNumbers)
        {
            int countOfEvens = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    countOfEvens++;
                }
            }

            int[] arrayWithLastNEvens;
            if (countOfEvens == 0)
            {
                arrayWithLastNEvens = null;
            }

            if (countOfEvens >= countOfNumbers)
            {
                arrayWithLastNEvens = new int[countOfNumbers];
            }

            else
            {
                arrayWithLastNEvens = new int[countOfEvens];
            }

            int Evenposition = 0;
            for (int i = data.Length - 1; i >= 0; i--)
            {
                if (data[i] % 2 == 0)
                {
                    arrayWithLastNEvens[Evenposition] = data[i];
                    Evenposition++;
                    if (Evenposition > arrayWithLastNEvens.Length - 1)
                    {
                        break;
                    }
                }
            }
            Array.Reverse(arrayWithLastNEvens);
            return arrayWithLastNEvens;
        }

        public static int[] GetFirstNEvenNumbers(int[] data, int countOfNumbers)
        {
            int countOfEvens = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    countOfEvens++;
                }
            }

            int[] arrayWithFirstNEvens;
            if (countOfEvens == 0)
            {
                arrayWithFirstNEvens = null;
            }
            
            if (countOfEvens >= countOfNumbers)
            {
                arrayWithFirstNEvens = new int[countOfNumbers];
            }

            else
            {
                arrayWithFirstNEvens = new int[countOfEvens];
            }

            int Evenposition = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    arrayWithFirstNEvens[Evenposition] = data[i];
                    Evenposition++;
                    if (Evenposition > arrayWithFirstNEvens.Length - 1)
                    {
                        break;
                    }
                }
            }

            return arrayWithFirstNEvens;
        }

        public static int[] GetLastNOddNumbers(int[] data, int countOfNumbers)
        {
            int countOfOdds = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 != 0)
                {
                    countOfOdds++;
                }
            }

            int[] arrayWithLastNOdds;

            if (countOfOdds == 0)
            {
                arrayWithLastNOdds = null;
            }


            if (countOfOdds >= countOfNumbers)
            {
                arrayWithLastNOdds = new int[countOfNumbers];
            }

            else
            {
                arrayWithLastNOdds = new int[countOfOdds];
            }

            int Oddposition = 0;
            for (int i = data.Length - 1; i >= 0; i--)
            {
                if (data[i] % 2 != 0)
                {
                    arrayWithLastNOdds[Oddposition] = data[i];
                    Oddposition++;
                    if (Oddposition > arrayWithLastNOdds.Length - 1)
                    {
                        break;
                    }
                }
            }
            Array.Reverse(arrayWithLastNOdds);
            return arrayWithLastNOdds;
        }

        public static int[] GetFirstNOddNumbers(int[] data, int countOfNumbers)
        {
            int countOfOdds = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 != 0)
                {
                    countOfOdds++;
                }
            }

            int[] arrayWithFirstNOdds;
            if (countOfOdds == 0)
            {
                arrayWithFirstNOdds = null;
            }

            else if (countOfOdds >= countOfNumbers)
            {
                arrayWithFirstNOdds = new int[countOfNumbers];
            }

            else
            {
                arrayWithFirstNOdds = new int[countOfOdds];
            }

            int Oddposition = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 != 0)
                {
                    arrayWithFirstNOdds[Oddposition] = data[i];
                    Oddposition++;
                    if (Oddposition > arrayWithFirstNOdds.Length - 1)
                    {
                        break;
                    }
                }
            }

            return arrayWithFirstNOdds;
        }

        public static int GetMinEvenPosition(int[] data)
        {
            int minEvenValue = int.MaxValue;
            int minEvenIndex = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    if (data[i] <= minEvenValue)
                    {
                        minEvenValue = data[i];
                        minEvenIndex = i;
                    }
                }
            }

            return minEvenIndex;
        }

        public static int GetMinOddPosition(int[] data)
        {
            int minOddValue = int.MaxValue;
            int minOddIndex = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 != 0)
                {
                    if (data[i] <= minOddValue)
                    {
                        minOddValue = data[i];
                        minOddIndex = i;
                    }
                }
            }

            return minOddIndex;
        }

        public static int GetMaxEvenPosition(int[] data)
        {
            int maxEvenValue = int.MinValue;
            int maxEvenIndex = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    if (data[i] >= maxEvenValue)
                    {
                        maxEvenValue = data[i];
                        maxEvenIndex = i;
                    }
                }
            }

            return maxEvenIndex;
        }

        public static int GetMaxOddPosition(int[] data)
        {
            int maxOddValue = int.MinValue;
            int maxOddIndex = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 != 0)
                {
                    if (data[i] >= maxOddValue)
                    {
                        maxOddValue = data[i];
                        maxOddIndex = i;
                    }
                }
            }

            return maxOddIndex;
        }

        public static int[] GetExchangedArray(int[] data, int index)
        {
            {
                int[] changedArrayLeftPart = new int[data.Length - (index + 1)];
                int[] changedArrayRightPart = new int[index + 1];

                int getValueForTheLeftPart = index;
                for (int i = 0; i < changedArrayLeftPart.Length; i++)
                {
                    changedArrayLeftPart[i] = data[getValueForTheLeftPart + 1];
                    getValueForTheLeftPart++;
                }
                for (int i = 0; i < changedArrayRightPart.Length; i++)
                {
                    changedArrayRightPart[i] = data[i];
                }

                for (int i = 0; i < changedArrayLeftPart.Length; i++)
                {
                    data[i] = changedArrayLeftPart[i];
                }

                int getValueForTheRigthPartOfArray = changedArrayLeftPart.Length;
                for (int i = 0; i < changedArrayRightPart.Length; i++)
                {
                    data[getValueForTheRigthPartOfArray] = changedArrayRightPart[i];
                    getValueForTheRigthPartOfArray++;
                }
                return data;

            }
        }
    }
}
