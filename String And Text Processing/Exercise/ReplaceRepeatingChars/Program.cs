namespace ReplaceRepeatingChars
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var finalText = new List<char>();
            finalText.Add(text[0]);

            foreach (var c in text)
            {
                if (c != finalText[finalText.Count - 1])
                {
                    finalText.Add(c);
                }                
            }

            Console.WriteLine(string.Join("",finalText));
        }
    }
}
