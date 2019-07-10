using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OldestFamilyMember
{
    public class Family
    {
        public Family()
        {
            this.Members = new List<Person>();
        }

        public List<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.Members.OrderByDescending(x => x.Age).First();
            
        }
    }
}
