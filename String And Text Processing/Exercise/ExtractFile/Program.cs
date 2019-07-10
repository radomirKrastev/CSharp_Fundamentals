namespace ExtractFile
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var path = Console.ReadLine().Split('\\');
            var file = path[path.Length - 1].Split('.')[0];
            var extension = path[path.Length - 1].Split('.')[1];
            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
