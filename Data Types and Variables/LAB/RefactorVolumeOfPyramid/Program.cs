
namespace RefactorVolumeOfPyramid
{
    using System;
    public class Program
    {
        public static void Main()
        {
            
            double length = double.Parse(Console.ReadLine());            
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double volume = (length*width*heigth)/3;
            Console.Write($"Length: Width: Height: Pyramid Volume: {volume:f2}");

        }
    }
}
