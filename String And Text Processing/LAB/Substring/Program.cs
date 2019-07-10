namespace Substring
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            while (text.Contains(word.ToLower()))
            {
                text = text.Replace(word.ToLower(), string.Empty);
            }
            
            Console.WriteLine(text);
        }
    }
}
