using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SerializationDemo
{
    [Serializable]
    public class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }

        [NonSerialized] // cannot be applied directly to properties, it can only be applied to fields
        int sal;
        public int Salary 
        {
            get { return sal; }
            set { sal = value; } 
        }
    }
}
