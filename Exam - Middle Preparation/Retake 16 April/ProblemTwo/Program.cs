namespace ProblemTwo
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var giftsList = Console.ReadLine().Split().ToList();
            var command = Console.ReadLine().Split();

            while(command[0]!="No")
            {
                if (command[0] == "OutOfStock")
                {
                    var gift = command[1];
                    while (giftsList.Contains(gift))
                    {
                        var index = giftsList.IndexOf(gift);
                        giftsList[index] = "None";
                    }
                }

                else if (command[0] == "Required")
                {
                    var newGift = command[1];
                    var index = int.Parse(command[2]);

                    if (index >= 0 && index < giftsList.Count)
                    {
                        giftsList[index] = newGift;
                    }
                }

                else
                {
                    var newGift = command[1];
                    giftsList[giftsList.Count - 1] = newGift;
                }

                command = Console.ReadLine().Split();
            }

            
                Console.WriteLine(string.Join(" ", giftsList.Where(x=>x!="None")));
            
            
        }
    }
}
