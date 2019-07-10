namespace StudentAcademy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var dataLines = int.Parse(Console.ReadLine());
            var studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < dataLines; i++)
            {
                var name = Console.ReadLine();
                var grade = decimal.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = new List<decimal>();
                }

                studentGrades[name].Add(grade);
            }

            
            var averageStudentGrades = new Dictionary<string, List<decimal>>();
            averageStudentGrades = studentGrades
                .Where(x => x.Value.Average() >= 4.5m)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in averageStudentGrades)
            {
                string name = kvp.Key;
                var grade = kvp.Value;
                Console.WriteLine($"{kvp.Key} -> {grade.Average():F2}");
            }
        }
    }
}
