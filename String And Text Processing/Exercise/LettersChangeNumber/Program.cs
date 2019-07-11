namespace LettersChangeNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var strings = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var letters = new Dictionary<char, int>();
            var counter = 1;

            for (int i = 'a'; i <= 'z'; i++)
            {
                letters.Add((char)i, counter);
                counter++;
            }

            decimal result = 0;
            bool isResultLegit = false;
            foreach (var str in strings)
            {

                var firstLetter = '\0';
                var lastLetter = '\0';
                var number = 0;

                if (char.IsLetter(str[0]) && char.IsLetter(str[str.Length - 1]) && (str.Substring(1, str.Length - 2)).All(Char.IsDigit))
                {
                    firstLetter += str[0];
                    lastLetter += str[str.Length - 1];
                    number = int.Parse(str.Substring(1, str.Length - 2));
                    isResultLegit = true;
                }

                else
                {
                    continue;
                }

                if (Char.IsUpper(firstLetter))
                {
                    var position = letters[Char.ToLower(firstLetter)];
                    result += (number * 1.0m) / position;
                }

                else
                {
                    var position = letters[firstLetter];
                    result += (number * 1.0m) * position;
                }

                if (Char.IsUpper(lastLetter))
                {
                    var position = letters[Char.ToLower(lastLetter)];
                    result -= position;
                }

                else
                {
                    var position = letters[lastLetter];
                    result += position;
                }
            }

            if (isResultLegit)
            {
                Console.WriteLine($"{result:F2}");
            }

        }
    }
}
