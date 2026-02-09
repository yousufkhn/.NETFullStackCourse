namespace StudentRecordMgmt
{
    public class Program
    {
        public static Dictionary<int, Student> studentDetails;

        public static void Main(string[] args)
        {
            
        }

        public class Student
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Course { get; set; }
            public int Marks { get; set; }

        }

        public class StudentUtility
        {
            public Dictionary<string,string> GetStudentDetails(string id)
            {
                foreach(var item in Program.studentDetails.Values)
                {
                    if (item.Id.Equals(id))
                    {
                        return new Dictionary<string,string>(id,item.Course);
                    }
                }
            }

            public Dictionary<string,Student> UpdateStudentMarks(string id,int marks)
            {
                foreach(var pair in studentDetails)
                {
                    Student studObj = null;
                    if (pair.Value.Id.Equals(id))
                    {
                        studObj = new Student
                        {
                            Id = pair.Value.Id,
                            Name = pair.Value.Name,
                            Marks = marks,
                            Course = pair.Value.Course
                        };
                        studentDetails[pair.Key] = studObj;
                    }
                    return new Dictionary<string, Student>(id,studObj);
                }
            }
        }
    }
}