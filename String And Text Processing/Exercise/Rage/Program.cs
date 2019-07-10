using System;

namespace Rage
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "a1b12";
            string sub = text.Substring(2, 3);
            Console.WriteLine(sub);
        }
    }
}
