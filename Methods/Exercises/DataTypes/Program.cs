namespace DataTypes
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string dataType=Console.ReadLine();
            PrintResult(dataType);
        }

        public static void PrintResult(string dataType)
        {
            if (dataType == "int")
            {
                int data = int.Parse(Console.ReadLine());
                Console.WriteLine(data*2);
            }
            else if (dataType == "real")
            {
                double data = double.Parse(Console.ReadLine());
                double result = data * 1.5;
                Console.WriteLine($"{result:F2}");
            }
            else if (dataType == "string")
            {
                string data = Console.ReadLine();
                Console.WriteLine("$"+data+"$");
            }
        }
    }
}
