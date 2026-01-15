using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Source s = new Source();
            Console.WriteLine(s.Add(1,2,3));
            Console.WriteLine(s.Add(1.2,1.2,1.2));
        }
    }
}
