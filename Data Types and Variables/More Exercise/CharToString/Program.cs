using System;

namespace CharToString
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = null;
            for(int i =0; i<3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                text = text + symbol.ToString();
            }

            Console.WriteLine(text);

        }




    }
}
