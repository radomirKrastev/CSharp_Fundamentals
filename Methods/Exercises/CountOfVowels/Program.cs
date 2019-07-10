
namespace CountOfVowels
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string data = Console.ReadLine();
            PrintCountOfVowels(data);
        }

        public static void PrintCountOfVowels(string text)
        {
            int countOfVowels = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == 'a' || text[i] == 'o' || text[i] == 'u' || text[i] == 'e' || text[i] == 'i' || text[i] == 'y' ||
                    text[i] == 'A' || text[i] == 'O' || text[i] == 'U' || text[i] == 'E' || text[i] == 'I' || text[i] == 'Y')
                {
                    countOfVowels++;
                }
            }
            Console.WriteLine(countOfVowels);
        }
    }
}
