using System;
using System.Text.RegularExpressions;

namespace LINQ_Prac
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Alok", Age = 20, Marks = 85, City = "Delhi" },
                new Student { Id = 2, Name = "Riya", Age = 22, Marks = 72, City = "Mumbai" },
                new Student { Id = 3, Name = "Rajat", Age = 19, Marks = 78, City = "Delhi" },
                new Student { Id = 4, Name = "Nitya", Age = 21, Marks = 88, City = "Pune" },
                new Student { Id = 5, Name = "Raman", Age = 23, Marks = 65, City = "Bangalore" },
                new Student { Id = 6, Name = "Smita", Age = 22, Marks = 92, City = "Mumbai" },
                new Student { Id = 7, Name = "Saket", Age = 19, Marks = 58, City = "Delhi" },
                new Student { Id = 8, Name = "Prachi", Age = 21, Marks = 88, City = "Pune" },
                new Student { Id = 9, Name = "Naresh", Age = 23, Marks = 80, City = "Bangalore" },
                new Student { Id = 10, Name = "Aarti", Age = 22, Marks = 84, City = "Mumbai" },
                new Student { Id = 11, Name = "Vartika", Age = 19, Marks = 78, City = "Delhi" },
                new Student { Id = 12, Name = "Manan", Age = 21, Marks = 88, City = "Pune" },
                new Student { Id = 13, Name = "Mahesh", Age = 25, Marks = 77, City = "Chennai" },
                new Student { Id = 14, Name = "Ranjeet", Age = 22, Marks = 80, City = "Mumbai" },
                new Student { Id = 15, Name = "Kajal", Age = 19, Marks = 78, City = "Chennai" }

            };

            // Easy 1
            // var query = students.Where(s=>s.Age>20).ToList();

            // Easy 2
            // var query = students.Select(s => s.Name).ToList();
            // System.Console.WriteLine(string.Join("\n",query));

            //Easy 3
            // var query = students.Count(s=>s.City.Equals("Mumbai"));
            // System.Console.WriteLine(query);

            // Easy 4
            // var query = students.Find(s=>s.Marks > 90);
            // System.Console.WriteLine(query == null? "Doesn't exist" : "Exists");

            // System.Console.WriteLine(students.Any(s=>s.Marks >90));

            // Easy 5
            // System.Console.WriteLine(students.Find(s=>s.City.Equals("Delhi")).Name);

            //Medium 1
            // var query = students.FindAll(s=> s.Marks>= 85 && s.Age < 22).ToList();
            
            //Medium 2
            // var query = students
            // .OrderByDescending(s=>s.Marks)
            // .ToList();

            //Medium 3
            // var query = students
            // .Select(s=> new {s.Name,s.Marks})
            // .ToList();

            // Medium 4
            // var query = students.Max(s=>s.Marks);
            // System.Console.WriteLine(query);

            // Medium 5
            var query = students.GroupBy(s=>s.City).ToList();
            foreach(var item in query)
            {
                System.Console.WriteLine(item.Key);
                foreach(var i in item)
                {
                    System.Console.WriteLine(i.Name);
                }
                    System.Console.WriteLine("===========");
            }
                        
        }
    }
}