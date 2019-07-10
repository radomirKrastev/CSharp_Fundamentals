
namespace RageExpenses
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int countOfHeadsetBreaks = lostGames / 2;
            int countOfMouseBreaks = lostGames / 3;
            int countOfKeyboardBreaks = lostGames / 6;
            int countOfDisplayBreaks = countOfKeyboardBreaks / 2;

            double expenses = countOfHeadsetBreaks * headsetPrice + countOfMouseBreaks * mousePrice
                + countOfKeyboardBreaks * keyboardPrice
                + countOfDisplayBreaks * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }

        
    }
}
