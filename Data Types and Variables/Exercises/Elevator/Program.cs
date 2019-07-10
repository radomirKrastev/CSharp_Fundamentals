
namespace Elevator
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int elevatorRoom = int.Parse(Console.ReadLine());
            int courses = 0;
            if (elevatorRoom > countOfPeople)
            {
                Console.WriteLine(1);
            }
            else if (countOfPeople % elevatorRoom!=0)
            {
                courses = countOfPeople / elevatorRoom+1;
                Console.WriteLine(courses);
            }
            else
            {
                courses = countOfPeople / elevatorRoom;
                Console.WriteLine(courses);
            }
            

        }
    }
}
