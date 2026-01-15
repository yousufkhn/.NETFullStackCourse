using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetailsProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Person> p = new List<Person>();

            p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
            p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
            p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
            p.Add(new Person { Name = "Jennifer", Address = "Adafdsf", Age = 33 });

            PublicImplementation pi = new PublicImplementation();
            Console.WriteLine(pi.GetName(p));
            Console.WriteLine(pi.Average(p));
            Console.WriteLine(pi.Max(p));1
        }
    }
}
