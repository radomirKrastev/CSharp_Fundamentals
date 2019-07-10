namespace ASCIISumator
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var firstSymbol = char.Parse(Console.ReadLine());
            var secondSymbol = char.Parse(Console.ReadLine());
            var data = Console.ReadLine();

            var startSymbolAscii = Math.Min((int)firstSymbol, (int)secondSymbol);
            var endSymbolAscii = Math.Max((int)secondSymbol, (int)firstSymbol);
            var result = 0;

            foreach (var c in data)
            {
                if ((int)c > startSymbolAscii && (int)c < endSymbolAscii)
                {
                    result += (int)c;
                }
            }

            Console.WriteLine(result);
        }
    }
}
