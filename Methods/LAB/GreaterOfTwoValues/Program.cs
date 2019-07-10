
namespace GreaterOfTwoValues
{   using System;
    public class Program
    {
        public static void Main()
        {
            string dataType = Console.ReadLine();
            if (dataType == "int")
            {
                int value1 = int.Parse(Console.ReadLine());
                int value2 = int.Parse(Console.ReadLine());
                int reuslt = GetMax(value1, value2);
                Console.WriteLine(reuslt);
            }

            else if (dataType == "char")
            {
                char value1 = char.Parse(Console.ReadLine());
                char value2 = char.Parse(Console.ReadLine());
                char reuslt = GetMax(value1, value2);
                Console.WriteLine(reuslt);
            }

            else 
            {
                string value1 = Console.ReadLine();
                string value2 = Console.ReadLine();
                string reuslt = GetMax(value1, value2);
                Console.WriteLine(reuslt);
            }
        }

        public static int GetMax (int value1, int value2)
        {
            return Math.Max(value1, value2);
        }

        public static char GetMax(char value1, char value2)
        {
            return (char)Math.Max(value1, value2);
        }

        public static string GetMax(string value1, string value2)
        {
            int result = string.Compare(value1, value2);
            if (result == 1)
            {
                return value1;
            }

            else
            {
                return value2;
            }
        }


    }
}
