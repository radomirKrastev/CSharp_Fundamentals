
namespace VendingMachine
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string moneyInput = Console.ReadLine();
            double totalMoney = 0;

            while(moneyInput != "Start")
            {
                if (moneyInput == "0.1" || moneyInput == "0.2" || moneyInput == "0.5" || moneyInput == "1" || moneyInput == "2" ||
                moneyInput == "Start")
                {
                    double moneyInserted = double.Parse(moneyInput);
                    totalMoney += moneyInserted;

                }
                else
                {
                    Console.WriteLine("Cannot accept "+moneyInput);
                }

                moneyInput = Console.ReadLine();
            }
            
            double productPrice = 0;

            string productInput = Console.ReadLine();
            while (productInput != "End")
            {
                switch (productInput)
                {
                    case "Nuts":
                        productPrice = 2;
                        if (productPrice > totalMoney)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine("Purchased "+productInput.ToLower());
                            totalMoney -= productPrice;
                        }
                        break;
                    case "Water":
                        productPrice = 0.7;
                        if (productPrice > totalMoney)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine("Purchased " + productInput.ToLower());
                            totalMoney -= productPrice;
                        }
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        if (productPrice > totalMoney)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine("Purchased " + productInput.ToLower());
                            totalMoney -= productPrice;
                        }
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        if (productPrice > totalMoney)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine("Purchased " + productInput.ToLower());
                            totalMoney -= productPrice;
                        }
                        break;
                    case "Coke":
                        productPrice = 1;
                        if (productPrice > totalMoney)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine("Purchased " + productInput.ToLower());
                            totalMoney -= productPrice;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                productInput = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalMoney:F2}");

        }
        
        
        
       
    }

}
