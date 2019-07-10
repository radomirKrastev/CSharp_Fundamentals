namespace ExtractPersonalInfo2
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                var name = string.Empty;
                int? age = null;
                var text = Console.ReadLine();
                var startIndexName = text.IndexOf('@')+1;
                var endIndexName = text.IndexOf('|');
                var startIndexAge = text.IndexOf('#')+1;
                var endIndexAge = text.IndexOf('*');

                name = text.Substring(startIndexName, endIndexName-startIndexName);
                age = int.Parse(text.Substring(startIndexAge, endIndexAge-startIndexAge));

                Console.WriteLine($"{name} is {age} years old.");                
            }
        }
    }
}
