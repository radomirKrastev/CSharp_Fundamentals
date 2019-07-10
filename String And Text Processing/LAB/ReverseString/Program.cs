namespace ReverseString
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var word = Console.ReadLine();

            while (word != "end")
            {
                var reverseWord = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverseWord += word[i];
                }

                Console.WriteLine(word+" = "+reverseWord);
                word = Console.ReadLine();
            }
        }
    }
}
