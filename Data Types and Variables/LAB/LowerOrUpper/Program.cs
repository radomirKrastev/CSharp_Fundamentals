
namespace LowerOrUpper
{
    using System;
    public class Program
    {
        public static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());
            bool isTheCharLower = symbol.ToString() == symbol.ToString().ToLower();
            if (isTheCharLower)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }

        } 
    }
}
