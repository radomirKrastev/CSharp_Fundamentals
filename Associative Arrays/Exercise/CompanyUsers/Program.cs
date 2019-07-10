namespace CompanyUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var companyEmployees = new Dictionary<string, List<string>>();

            var command = Console.ReadLine();
            while (command != "End")
            {
                var data = command.Split(" -> ").ToList();
                var company = data[0];
                var employee = data[1];

                if (!companyEmployees.ContainsKey(company))
                {
                    companyEmployees[company]=new List <string> ();
                    companyEmployees[company].Add(employee);
                }
                else
                {
                    if (companyEmployees[company].Contains(employee))
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        companyEmployees[company].Add(employee);
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var kvp in companyEmployees.OrderBy(x=>x.Key))
            {
                Console.WriteLine(kvp.Key);

                Console.WriteLine("-- "+string.Join(Environment.NewLine+"-- ",kvp.Value));
            }
        }
    }
}
