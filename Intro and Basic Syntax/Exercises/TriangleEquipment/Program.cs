
namespace TriangleEquipment
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int numberData = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberData; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i+" ");
                    if (j == i)
                    {
                        Console.Write(i);
                    }
                }
                Console.Write(Environment.NewLine);
            }
        }


    }
}
