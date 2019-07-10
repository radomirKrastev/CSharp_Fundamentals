
namespace MiddleCharacters
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            PrintsMiddleChars(input);
        }

        public static void PrintsMiddleChars(string input)
        {
            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < input.Length/2; i++)
                {
                    if (i + 1 == input.Length / 2)
                    {
                        Console.Write(input[i]);
                        Console.Write(input[i+1]);
                    }
                }
            }

            else
            {
                for (int i = 0; i < (input.Length+1)/2; i++)
                {
                    if (i + 1 == (input.Length+1) / 2)
                    {
                        Console.Write(input[i]);
                        
                    }
                }
            }
        }
    }
}
