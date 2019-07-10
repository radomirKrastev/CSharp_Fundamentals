namespace OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split();
            var persons = new List<Person>();
            while (data[0] != "End")
            {
                var name = data[0];
                var id = data[1];
                var age = int.Parse(data[2]);
                var person = new Person { Name = name, ID = id, Age = age };
                persons.Add(person);
                data = Console.ReadLine().Split();
            }

            foreach (var person in persons.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

}
