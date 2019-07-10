
namespace CenturiesToMinutes
{
    using System;
    using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = years * 365.2422;
            long hours = (int)days * 24;
            ulong minutes = (ulong)hours * 60;

            BigInteger sum = new BigInteger(91310550000) * 91310550000 * 24;
            Console.WriteLine(sum);

        } 
    }
}
