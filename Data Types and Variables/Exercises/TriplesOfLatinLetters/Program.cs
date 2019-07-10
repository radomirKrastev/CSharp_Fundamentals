
namespace TriplesOfLatinLetters
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int lettersCount = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97+lettersCount; i++)
            {
                for (int j = 97; j < 97+lettersCount; j++)
                {
                    for (int k = 97; k < 97+lettersCount; k++)
                    {
                        char firstLetter = (char)i;
                        char secondLetter = (char)j;
                        char thirdLetter = (char)k;
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
