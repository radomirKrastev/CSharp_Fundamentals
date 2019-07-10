namespace WinningTicket
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var specialSymbols = new char[] { '@', '#', '$', '^' };

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var firstHalf = ticket.Substring(0, 10);
                var secondHalf = ticket.Substring(10, 10);
                var winningTicket = false;

                foreach (var symbol in specialSymbols)
                {
                    var countFirstHalf = CountWinningSymbols(symbol, firstHalf);
                    var countSecondHalf = CountWinningSymbols(symbol, secondHalf);

                    if (countFirstHalf == 10 && countSecondHalf == 10)
                    {
                        var result = "ticket " + '"' + ticket + '"' + " - " + 10 + symbol + " Jackpot!";
                        Console.WriteLine(result);
                        winningTicket = true;
                        break;
                    }

                    else if (countFirstHalf >= 6 && countSecondHalf >= 6)
                    {
                        var matchCount = Math.Min(countFirstHalf, countSecondHalf);
                        var result = "ticket " + '"' + ticket + '"' + " - " + matchCount + symbol;
                        winningTicket = true;
                        Console.WriteLine(result);
                        break;
                    }
                }

                if (!winningTicket)
                {
                    var result = "ticket " + '"' + ticket + '"' + " - no match";
                    Console.WriteLine(result);
                }
            }
        }

        public static int CountWinningSymbols(char symbol, string ticketHalf)
        {
            var highestCount = 0;
            var counter = 0;
            foreach (var c in ticketHalf)
            {
                if (c == symbol)
                {
                    counter++;
                    if (counter > highestCount)
                    {
                        highestCount = counter;
                    }
                }

                else
                {
                    counter = 0;
                }
            }

            return highestCount;
        }

        //public static bool containswinningsymbols(string halfone, string halftwo)
        //{
        //    var symbols = false;

        //    if ((!halfone.contains('@') || halfone.contains('#') || halfone.contains('$') || halfone.contains('^'))
        //        && (!halftwo.contains('@') || halftwo.contains('#') || halftwo.contains('$') || halftwo.contains('^')))
        //    {
        //        symbols = true;
        //    }

        //    return symbols;
        //}
    }
}
