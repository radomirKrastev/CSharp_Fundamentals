
namespace Vacation
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int countOfPeopleInGroup = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            Console.WriteLine($"Total price: {GetNetPrice(countOfPeopleInGroup,typeOfGroup,dayOfTheWeek):F2}");
        }

        public static double GetNetPrice(int groupCount, string typeOfGroup, string dayOfTheWeek)
        {
            double grossPrice = GetGrossPrice(groupCount, typeOfGroup, dayOfTheWeek);
            double netPrice = grossPrice;

            switch (typeOfGroup)
            {
                case "Students":
                    if (groupCount >= 30)
                    {
                        netPrice = netPrice - (grossPrice * 0.15);
                    }
                    break;
                case "Business":
                    if (groupCount >= 100)
                    {
                        netPrice = netPrice - ((grossPrice / groupCount) * 10);
                    }
                    break;
                case "Regular":
                    if (groupCount>=10 && groupCount <= 20)
                    {
                        netPrice = netPrice - (grossPrice * 0.05);
                    }
                    break;
            }

            return netPrice;
        }

        public static double GetGrossPrice(int groupCount, string typeOfGroup, string dayOfTheWeek)
        {
            double price = 0;
            switch (dayOfTheWeek)
            {
                case "Friday":
                    price = GetPriceForFriday(groupCount, typeOfGroup);
                    break;
                case "Saturday":
                    price = GetPriceForSaturday(groupCount, typeOfGroup);
                    break;
                case "Sunday":
                    price = GetPriceForSunday(groupCount, typeOfGroup);
                    break;
            }

            return price;

        }

        public static double GetPriceForFriday (int groupCount, string typeOfgroup)
        {
            double price = 0;
            switch (typeOfgroup)
            {
                case "Students":
                    price = 8.45 * groupCount;
                    break;
                case "Business":
                    price = 10.9 * groupCount;
                    break;
                case "Regular":
                    price = 15 * groupCount;
                    break;
            }

            return price;
        }

        public static double GetPriceForSaturday (int groupCount, string typeOfgroup)
        {
            double price = 0;
            switch (typeOfgroup)
            {
                case "Students":
                    price = 9.8 * groupCount;
                    break;
                case "Business":
                    price = 15.6 * groupCount;
                    break;
                case "Regular":
                    price = 20 * groupCount;
                    break;
            }

            return price;
        }

        public static double GetPriceForSunday(int groupCount, string typeOfgroup)
        {
            double price = 0;
            switch (typeOfgroup)
            {
                case "Students":
                    price = 10.46 * groupCount;
                    break;
                case "Business":
                    price = 16 * groupCount;
                    break;
                case "Regular":
                    price = 22.5 * groupCount;
                    break;
            }

            return price;
        }

    }
}
