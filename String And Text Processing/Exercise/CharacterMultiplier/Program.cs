namespace CharacterMultiplier
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var strings = Console.ReadLine().Split(" ");  //(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var stringOne = strings[0];
            var stringTwo = strings[1];
            var result = 0;
            if (stringOne.Length > stringTwo.Length)
            {
                for (int i = 0; i < stringTwo.Length; i++)
                {
                    if (i == stringTwo.Length - 1)
                    {
                        result += (int)stringOne[i] * (int)stringTwo[i];
                        for (int j = i+1; j < stringOne.Length; j++)
                        {
                            result += stringOne[j];
                        }

                        break;
                    }
                                        
                    result += (int)stringOne[i] * (int)stringTwo[i];
                }
            }

            else if (stringTwo.Length > stringOne.Length)
            {
                for (int i = 0; i < stringOne.Length; i++)
                {
                    if (i == stringOne.Length - 1)
                    {
                        result += (int)stringOne[i] * (int)stringTwo[i];
                        for (int j = i+1; j < stringTwo.Length; j++)
                        {
                            result += stringTwo[j];
                        }

                        break;
                    }

                    result += (int)stringOne[i] * (int)stringTwo[i];
                }
            }

            else
            {
                for (int i = 0; i < stringOne.Length; i++)
                {
                    result += (int)stringOne[i] * (int)stringTwo[i];
                }
            }

            Console.WriteLine(result);               
        }
    }
}
