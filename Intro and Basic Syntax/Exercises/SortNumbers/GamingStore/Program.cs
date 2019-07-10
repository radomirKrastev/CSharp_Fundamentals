
namespace GamingStore
{
    using System;
    public class Program
    {
        public static void Main()
        {
            double initialBalance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double currentBalance = initialBalance;
            bool outOfMoney = false;
            while (input!="Game Time")
            {
                
                if (currentBalance < GetGamePrice(input))
                {
                    Console.WriteLine("Too Expensive");
                    
                }
                else 
                {
                    PrintGameName(input);
                    GetBalance(currentBalance, input);
                    currentBalance = GetBalance(currentBalance, input);
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    outOfMoney = true;
                    break;
                }

                input = Console.ReadLine();
            }

            if (outOfMoney == false)
            {
                double totalMoneySpentOnGames = initialBalance - currentBalance;

                Console.WriteLine($"Total spent: ${totalMoneySpentOnGames:F2}. Remaining: ${currentBalance:F2}");
            }
        }

        public static double GetBalance (double currentBalance, string gameName)
        {
            double balance = currentBalance;
            switch (gameName)
            {
                case "OutFall 4":
                    balance -= 39.99;
                    break;
                case "CS: OG":
                    balance -= 15.99;
                    break;
                case "Zplinter Zell":
                    balance -= 19.99;
                    break;
                case "Honored 2":
                    balance -= 59.99;
                    break;
                case "RoverWatch":
                    balance -= 29.99;
                    break;
                case "RoverWatch Origins Edition":
                    balance -= 39.99;
                    break;
                default:
                    balance -= 0;
                    break;
            }

            return balance;
        } 

        public static void PrintGameName(string game)
        {
            if (game == "OutFall 4" || game == "CS: OG" || game == "Zplinter Zell"
                || game == "Honored 2" || game == "RoverWatch" || game == "RoverWatch Origins Edition")
            {
                Console.WriteLine("Bought " + game);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        public static double GetGamePrice(string gameName)
        {
            double price = 0;
            switch (gameName)
            {
                case "OutFall 4":
                    price = 39.99;
                    break;
                case "CS: OG":
                    price = 15.99;
                    break;
                case "Zplinter Zell":
                    price = 19.99;
                    break;
                case "Honored 2":
                    price = 59.99;
                    break;
                case "RoverWatch":
                    price = 29.99;
                    break;
                case "RoverWatch Origins Edition":
                    price = 39.99;
                    break;
                default:
                    price = 0;
                    break;
            }

            return price;
        }
    }
}
