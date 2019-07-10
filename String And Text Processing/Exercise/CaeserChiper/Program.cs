namespace CaeserChiper
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var encryptedText = string.Empty;
            foreach (var c in text)
            {
                var charCode = (int)c + 3;
                char symbol = (char)charCode;
                encryptedText += symbol;
            }

            Console.WriteLine(encryptedText);
        }
    }
}
