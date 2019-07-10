namespace RageQuit
{
    using System;
    using System.Text;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var finalText = new StringBuilder();
            var startIndex = 0;            

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    var length = i - startIndex;
                    var str = (input.Substring(startIndex, length)).ToUpper();
                    var repeating = input[i].ToString();
                    startIndex = i+1;

                    if (i < input.Length-1)
                    {
                        if (char.IsDigit(input[i + 1]))
                        {
                            repeating = input[i].ToString() + input[i + 1].ToString();
                            i++;
                            startIndex = i+1;
                        }
                    }

                    for (int j = 0; j < int.Parse(repeating); j++)
                    {
                        finalText.Append(str);
                    }
                }
            }

            string uniqueSymbols = new String(finalText.ToString().Distinct().ToArray());
            
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
            Console.WriteLine(finalText.ToString());
        }
    }
}
