
namespace ReverseString
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            string dataText = Console.ReadLine();

            string result = null;
            for (int i = dataText.Length-1; i >=0 ; i--)
            {
                char symbol = dataText[i];
                result += symbol.ToString();
            }

            Console.WriteLine(result);
        }
    }
}
