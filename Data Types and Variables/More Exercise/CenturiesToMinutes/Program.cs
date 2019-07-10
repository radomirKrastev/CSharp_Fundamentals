using System;
using System.Numerics;
namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            BigInteger days = new BigInteger(years * 365.2422m);
            BigInteger hours = days * 24;
            BigInteger minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");



        }
    }
}
