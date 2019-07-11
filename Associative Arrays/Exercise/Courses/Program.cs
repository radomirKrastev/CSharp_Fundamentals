namespace Courses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var courseData = Console.ReadLine().Split(" : ").ToList();
            var courseStudentInfo = new Dictionary<string, List<string>>();

            while (courseData[0]!="end")
            {
                var course = courseData[0];
                var student = courseData[1];
                if (!courseStudentInfo.ContainsKey(course))
                {
                    courseStudentInfo[course] = new List<string>();
                }
                courseStudentInfo[course].Add(student);

                courseData = Console.ReadLine().Split(" : ").ToList();
            }

            foreach (var kvp in courseStudentInfo.OrderByDescending(x=> x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                Console.WriteLine("-- "+string.Join(Environment.NewLine+"-- ", kvp.Value.OrderBy(x => x)));                
            }
        }
    }
}
