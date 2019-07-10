namespace Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var studentInfo = Console.ReadLine().Split(' ').ToList();
            var studentsList = new List<Student>();
            while (studentInfo[0] != "end")
            {
                var firstName = studentInfo[0];
                var lastName = studentInfo[1];
                var age = studentInfo[2];
                var town = studentInfo[3];

                Student student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = town
                };
                studentsList.Add(student);
                studentInfo = Console.ReadLine().Split(' ').ToList();
            }

            var specificTown = Console.ReadLine();
            foreach (var student in studentsList.Where(x=>x.HomeTown==specificTown))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

}
