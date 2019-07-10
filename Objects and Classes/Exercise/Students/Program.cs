namespace Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var studentsCount = int.Parse(Console.ReadLine());
            var studentsList = new List<Student>();
            for (int i = 0; i < studentsCount; i++)
            {
                var studentData = Console.ReadLine().Split();
                var firstName = studentData[0];
                var lastName = studentData[1];
                var grade = double.Parse(studentData[2]);

                var student = new Student(firstName, lastName, grade);
                studentsList.Add(student);
            }

            foreach (var student in studentsList.OrderByDescending(x=>x.Grade))
            {
                Console.WriteLine($"{ student.FirstName} { student.LastName}: { student.Grade:F2}");
            }
        }
    }


}
