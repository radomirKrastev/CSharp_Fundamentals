namespace DigitsLetterOthers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var digits = string.Empty;
            var letters = string.Empty;
            var others = string.Empty;

            foreach (var c in text)
            {
                if (Char.IsDigit(c))
                {
                    digits += c;
                }

                else if (char.IsLetter(c))
                {
                    letters += c;
                }

                else
                {
                    others += c;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
