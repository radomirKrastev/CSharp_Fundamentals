namespace OldestFamilyMember
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var membersCount = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < membersCount; i++)
            {
                var memberInfo = Console.ReadLine().Split();
                var name = memberInfo[0];
                var age = int.Parse(memberInfo[1]);

                var member = new Person
                {
                    Name = name,
                    Age = age
                };

                family.AddMember(member);
            }

            var oldestMemberName = family.GetOldestMember().Name;
            var oldestMemberAge = family.GetOldestMember().Age;
            Console.WriteLine(oldestMemberName+" "+oldestMemberAge);
        }
    }
}
