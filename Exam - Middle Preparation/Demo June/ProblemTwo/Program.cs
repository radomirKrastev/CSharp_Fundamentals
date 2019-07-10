namespace ProblemTwo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var giftList = Console.ReadLine().Split(' ').ToList();

            var input = Console.ReadLine();

            while(input!="No Money")
            {
                var command = input.Split(' ').ToArray();

                if(command[0]== "OutOfStock")
                {
                    var gift = command[1];

                    while (giftList.Contains(gift))
                    {
                        var index = giftList.IndexOf(gift);
                        giftList[index] = "None";
                    }
                }

                else if (command[0] == "Required")
                {
                    var currentGiftIndex = int.Parse(command[2]);
                    var changeGift = command[1];

                    if (currentGiftIndex >= 0 && currentGiftIndex < giftList.Count)
                    {
                        giftList[currentGiftIndex] = changeGift;
                    }
                }

                else
                {
                    var changeGift = command[1];
                    giftList[giftList.Count - 1] = changeGift;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",giftList.Where(x=>x!="None")));
        }
    }
}
