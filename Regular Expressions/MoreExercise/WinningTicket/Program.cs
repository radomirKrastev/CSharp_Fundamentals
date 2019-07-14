namespace WinningTicket
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var jackpotPattern = @"[$]{20}|[@]{20}|[#]{20}|[\^]{20}";
            var winningHalf = @"([$]{6,}|[@]{6,}|[#]{6,}|[\^]{6,})";
            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    if (Regex.IsMatch(ticket, jackpotPattern))
                    {
                        Console.WriteLine("ticket "+ '"' +ticket+'"'+" - " +"10"+ticket[0] +" Jackpot!");
                        continue;
                    }

                    var firstHalfTicket = ticket.Substring(0, 10);
                    var secondHalftTicket = ticket.Substring(10, 10);

                    if (Regex.IsMatch(firstHalfTicket, winningHalf) && Regex.IsMatch(secondHalftTicket, winningHalf))
                    {
                        var firstWinSequence = Regex.Match(firstHalfTicket, winningHalf).ToString();
                        var secondWinSequence = Regex.Match(secondHalftTicket, winningHalf).ToString();

                        if (firstWinSequence[0] == secondWinSequence[0])
                        {
                            var winningSymbol = firstWinSequence[0];
                            var winningLength = Math.Min(firstWinSequence.Length, secondWinSequence.Length);
                            Console.WriteLine("ticket " + '"' + ticket + '"' + " - " + winningLength + winningSymbol);
                        }

                        else
                        {
                            Console.WriteLine("ticket " + '"' + ticket + '"' + " - " + "no match");
                            continue;
                        }
                    }

                    else
                    {
                        Console.WriteLine("ticket " + '"' + ticket + '"' + " - " +"no match");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
            }
        }
    }
}
