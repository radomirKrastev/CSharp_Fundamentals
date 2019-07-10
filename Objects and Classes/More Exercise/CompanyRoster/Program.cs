namespace CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numberOfEmployees = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var employeeData = Console.ReadLine().Split();
                var name = employeeData[0];
                var salary = double.Parse(employeeData[1]);
                var department = employeeData[2];

                var employee = new Employee
                {
                    Name = name,
                    Salary = salary,
                    Department = department
                };

                employees.Add(employee);
            }

            var departments = new List<Department>();

            foreach (var employee in employees)
            {
                var department = employee.Department;
                double salary = employee.Salary;


                if (!departments.Select(x => x.Name).Contains(department))
                {
                    var dep = new Department()
                    {
                        Name = department,
                        Salary = new List<double> { salary }
                    };
                    departments.Add(dep);
                }

                else
                {
                    foreach (var dep in departments.Where(x => x.Name == department))
                    {
                        dep.Salary.Add(salary);
                    }
                }
            }

            var highestAverageSalary = double.MinValue;
            var bestSalaryDepartment = "";

            foreach (var department in departments)
            {
                if (department.Salary.Average() > highestAverageSalary)
                {
                    bestSalaryDepartment = department.Name;
                    highestAverageSalary = department.Salary.Average();
                }
            }

            Console.WriteLine($"Highest Average Salary: {bestSalaryDepartment}");
            foreach (var employee in employees.Where(x=>x.Department==bestSalaryDepartment).OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }
   
}
