using LPU_Common;
using LPU_Entity;
using LPU_Exceptions;

namespace LPU_DAL
{
    public class StudentDAO : IStudentCRUD
    {
        static List<Student> studentList = null;

        public StudentDAO()
        {
            // collection initializer
            studentList = new List<Student>()
            {
                new Student(){StudentID = 101,Name = "Yousuf",Course=CourseType.CSE,Address = "Chandigarh"},
                new Student(){StudentID = 102,Name = "Aaysha",Course=CourseType.IT,Address = "Jalandhar"},
                new Student(){StudentID = 103,Name = "Aman",Course=CourseType.Electrical,Address = "Phagwara"},
                new Student(){StudentID = 104,Name = "Riya",Course=CourseType.Mechanical,Address = "Delhi"},
                new Student(){StudentID = 105,Name = "Rajat",Course=CourseType.Civil,Address = "Kochi"},
                new Student(){StudentID = 106,Name = "Yousuf",Course=CourseType.CSE,Address = "Chandigarh"},
                new Student(){StudentID = 107,Name = "Aaysha",Course=CourseType.IT,Address = "Jalandhar"},
                new Student(){StudentID = 108,Name = "Aman",Course=CourseType.Electrical,Address = "Phagwara"},
                new Student(){StudentID = 109,Name = "Riya",Course=CourseType.Mechanical,Address = "Delhi"},
                new Student(){StudentID = 110,Name = "Rajat",Course=CourseType.Civil,Address = "Kochi"},
            };
        }
        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool EnrollStudent(Student sObj)
        {
            bool flag = false;
            if (sObj == null)
            {
                studentList.Add(sObj);
                flag = true;
            }
            return flag;   
        }

        public Student SearchStudentByID(int rollNo)
        {
            Student myStud = null;
            if(rollNo != 0)
            {
                myStud = studentList.Find(s => s.StudentID == rollNo);
                if(myStud == null)
                {
                    throw new LPUException("Student Not Found!");
                }
                else
                {
                    return myStud;
                }
            }
            else
            {
                throw new LPUException("Roll no can't be 0, Error Generated");
            }
        }

        public List<Student> SearchStudentByName(string name)
        {
            List<Student> data = studentList.FindAll(p => p.Name.Contains(name));
            return data;
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            throw new NotImplementedException();
        }
    }
}
