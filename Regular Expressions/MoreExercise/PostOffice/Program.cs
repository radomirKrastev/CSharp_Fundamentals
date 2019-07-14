namespace PostOffice
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var message = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            var lettersPattern = @"[$][A-Z]+[$]|[#][A-Z]+[#]|[%][A-Z]+[%]|[*][A-Z]+[*]|[&][A-Z]+[&]";
            var letters = (Regex.Match(message[0], lettersPattern)).Value;
            letters = letters.Remove(0,1);
            letters = letters.Remove(letters.Length-1);

            var wordsLengthPattern = @"\d{2}:\d{2}";
            var wordsLength = Regex.Matches(message[1], wordsLengthPattern).ToList();

            var wordsInfo = new Dictionary<char, List<int>>();

            foreach (var letter in letters)
            {
                foreach (Match wordLength in wordsLength)
                {
                    var startLetterAsciiCode = int.Parse(wordLength.Value.Split(":")[0]);
                    var startLetter = (char)(startLetterAsciiCode);

                    if (letter == startLetterAsciiCode)
                    {
                        var length = int.Parse(wordLength.Value.Split(":")[1])+1;

                        if (length == 1)
                        {
                            continue;
                        }

                        if (!wordsInfo.ContainsKey(letter))
                        {
                            var lengthsList = new List<int>();
                            wordsInfo.Add(letter, lengthsList);
                        }

                        wordsLength.Remove(wordLength);
                        wordsInfo[letter].Add(length);
                        break;
                    }
                }
            }

            var messageWords = message[2].Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            foreach (var letter in wordsInfo)
            {
                foreach (var word in messageWords)
                {                
                    if (word[0] == letter.Key)
                    {
                        foreach (var length in letter.Value)
                        {
                            if (word.Length == length)
                            {
                                Console.WriteLine(word);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
