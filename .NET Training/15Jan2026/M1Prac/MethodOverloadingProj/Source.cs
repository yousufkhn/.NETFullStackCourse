using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingProj
{
    internal class Source
    {
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }
        public double Add(double a,double b,double c)
        {
            return a + b + c;
        }
    }
}
