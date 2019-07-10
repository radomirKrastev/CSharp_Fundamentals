namespace MorseCodeTranslator
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    public class Program
    {
        private static Dictionary<string, string> _morseAlphabetDictionary;

        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

            
            InitializeDictionary();

            Console.WriteLine(Translate(input));
        }

        private static void InitializeDictionary()
        {
            _morseAlphabetDictionary = new Dictionary<string, string>()
            {
                                       { ".-", "a" },
                                       { "-...", "b" },
                                       { "-.-.", "c" },
                                       { "-..", "d" },
                                       { ".", "e" },
                                       { "..-.", "f" },
                                       { "--.", "g" },
                                       { "....", "h" },
                                       { "..", "i" },
                                       { ".---", "j" },
                                       { "-.-", "k" },
                                       { ".-..", "l" },
                                       { "--", "m" },
                                       { "-.", "n" },
                                       { "---", "o" },
                                       { ".--.", "p" },
                                       { "--.-", "q" },
                                       { ".-.", "r" },
                                       { "...", "s" },
                                       { "-", "t" },
                                       { "..-", "u" },
                                       { "...-", "v" },
                                       { ".--", "w" },
                                       { "-..-", "x" },
                                       { "-.--", "y" },
                                       { "--..", "z" },
            };
        }

        private static string Translate(string[] input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string morseWord in input)
            {
                if (_morseAlphabetDictionary.ContainsKey(morseWord))
                {
                    stringBuilder.Append(_morseAlphabetDictionary[morseWord].ToUpper());
                }
                else if (morseWord == "|")
                {
                    stringBuilder.Append(" ");
                }                
            }

            return stringBuilder.ToString();
        }
    }
}
