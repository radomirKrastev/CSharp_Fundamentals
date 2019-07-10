
namespace PadawanEquipment
{
    using System;
    public class Program
    {
        public static void Main()
        {
            double disposableMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double singleLightsaberPrice = double.Parse(Console.ReadLine());
            double singleRobePrice = double.Parse(Console.ReadLine());
            double singleBeltPrice = double.Parse(Console.ReadLine());

            

            double price = Math.Ceiling(countOfStudents + (0.1 * countOfStudents)) * singleLightsaberPrice
                + (singleRobePrice * countOfStudents) + singleBeltPrice * (countOfStudents - (countOfStudents / 6));

            if (disposableMoney >= price)
            {
                Console.WriteLine($"The money is enough - it would cost {price:F2}lv."); 
            }
            else
            {
                double difference = price - disposableMoney;
                Console.WriteLine($"Ivan Cho will need {difference:F2}lv more.");
            }
        }
    }
}
