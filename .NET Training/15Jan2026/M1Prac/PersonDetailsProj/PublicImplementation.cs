using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetailsProj
{
    internal class PublicImplementation
    {
        public string GetName(IList<Person> people)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Person p in people)
            {
                sb.Append(p.Name).Append(p.Address);
            }
            return sb.ToString();
        }

        public double Average(IList<Person> people)
        {
            return people.Average(p => p.Age);
        }

        public int Max(IList<Person> people)
        {
            return people.Max(p => p.Age);
        }
    }
}
