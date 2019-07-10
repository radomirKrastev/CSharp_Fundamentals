
namespace SumOfChars
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int countOfSymbols=int.Parse(Console.ReadLine());
            int sumOfSymbolValues = 0;
            for (int i = 0; i < countOfSymbols; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int SymbolAsciiValue = symbol;
                sumOfSymbolValues += SymbolAsciiValue;
            }
            Console.WriteLine("The sum equals: "+sumOfSymbolValues);
        }
    }
}
