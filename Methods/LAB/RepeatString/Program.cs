
namespace RepeatString
{
    using System;
    using System.Text;
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int countOfTimes = int.Parse(Console.ReadLine());
            string result = GetRepeatedString(text, countOfTimes);
            Console.WriteLine(result);
        }

        public static string GetRepeatedString (string text, int countOfTimes)
        {
            StringBuilder finalString = new StringBuilder();

            for (int i = 0; i < countOfTimes; i++)
            {
                finalString.Append(text);
            }
            return finalString.ToString();
        }
    }
}
