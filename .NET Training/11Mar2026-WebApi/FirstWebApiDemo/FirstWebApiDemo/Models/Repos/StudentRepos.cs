
namespace FirstWebApiDemo.Models.Repos
{
    public class StudentRepos : IRepos<Student>
    {
        public static List<Student> students = null;

        public StudentRepos()
        {
            if (students == null)
            {
                students = new List<Student>()
                {
                    new Student(){RollNo = 101,Name="Alok",City="Jalandhar",PhoneNumber="8582837232"},
                    new Student(){RollNo = 102,Name="Riya",City="Ludhiana",PhoneNumber="2312312312"},
                    new Student(){RollNo = 103,Name="Rajat",City="Phagwara",PhoneNumber="85555522222"},
                };

            }
        }
        public bool Add(Student item)
        {
            if (item != null)
            {
                students.Add(item);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Student stud = students.Find(s => s.RollNo == id);
            if (stud != null)
            {
                students.Remove(stud);
                return true;
            }
            return false;
        }

        public Student Get(int id)
        {
            var find = students.Find(s => s.RollNo == id);
            if (find== null)
            {
                throw new Exception("Student Record not available");
            }
            return find;
        }

        public ICollection<Student> GetAll()
        {
            return students;
        }

        public bool Update(int id, Student item)
        {
            Student stud = students.Find(s => s.RollNo == id);
            if(stud!= null && item!=null)
            {
                stud.Name = item.Name;
                stud.City = item.City;
                stud.PhoneNumber = item.PhoneNumber;
                return true;
            }
            return false;
        }
    }
}
