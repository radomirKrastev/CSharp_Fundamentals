using System;

namespace RefactorVolumePyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            
            Console.Write("Heigth: ");
            double heigth = double.Parse(Console.ReadLine());

            double Volume = (length + width + heigth) / 3;
            Console.WriteLine($"Pyramid Volume: {Volume:F2}");

        }
    }
}
