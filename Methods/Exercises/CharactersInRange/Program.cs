
namespace CharactersInRange
{
    using System;
    public class Program
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());        
            char lastChar = char.Parse(Console.ReadLine());
            PrintInBetweenChars(firstChar, lastChar);
        }

        public static void PrintInBetweenChars (char firstChar, char lastChar)
        {
            char nextChar = ' ';
            if (firstChar < lastChar)
            {
                for (int i = firstChar + 1; i < lastChar; i++)
                {
                    nextChar = (char)i;
                    Console.Write(nextChar + " ");
                }
            }
            else
            {
                for (int i = lastChar + 1; i < firstChar; i++)
                {
                    nextChar = (char)i;
                    Console.Write(nextChar + " ");
                }
            }
        }
    }
}
