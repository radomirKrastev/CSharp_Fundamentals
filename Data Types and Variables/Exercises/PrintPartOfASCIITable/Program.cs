
namespace PrintPartOfASCIITable
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int asciStart = int.Parse(Console.ReadLine());
            int asciEnd = int.Parse(Console.ReadLine());

            for (int i = asciStart; i <= asciEnd; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol+" ");
            }
        }
    }
}
