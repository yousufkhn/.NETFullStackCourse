using System.Text.Json;

namespace JsonDemo
{
    public class Program{

        public static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student{ Id = 1,Name="Yousuf",Marks = new List<int>{50,100},Grade = "A"},
                new Student{ Id = 2,Name="Aaysha",Marks = new List<int>{60,100},Grade = "B"},
                new Student{ Id = 3,Name="Khan",Marks = new List<int>{70,100},Grade = "C"},
                new Student{ Id = 4,Name="Muhammad",Marks = new List<int>{80,100},Grade = "D"}
            };

            var json = JsonSerializer.Serialize(students);
            File.WriteAllText("students.json",json);
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<int> Marks{get;set;}
            public string Grade{get;set;}
        }
    }
}