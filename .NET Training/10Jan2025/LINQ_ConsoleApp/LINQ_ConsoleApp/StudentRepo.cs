using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ConsoleApp
{
    public class StudentRepo
    {
        static List<Student> studList = null;
        public StudentRepo()
        {
            if (studList == null)
            {
                // Collection initializer
                studList = new List<Student>()
                {
                    new Student(){RollNo = 1,Name="Amit",Gender = "Male",Marks = 80,Fees = 1500},
                    new Student(){RollNo = 2,Name="Yousuf",Gender = "Male",Marks = 80,Fees = 1600},
                    new Student(){RollNo = 3,Name="Alok",Gender = "Male",Marks = 80,Fees = 2000},
                    new Student(){RollNo = 4,Name="Aaysha",Gender = "Female",Marks = 80,Fees = 1000},
                    new Student(){RollNo = 5,Name="Golden",Gender = "Female",Marks = 80,Fees = 500},
                    new Student(){RollNo = 6,Name="Rahul",Gender = "Male",Marks = 80, Fees = 4000},
                };
            }
        }

        public List<Student> GetAllStudents()
        {
            return studList;
        }
    }   
}
