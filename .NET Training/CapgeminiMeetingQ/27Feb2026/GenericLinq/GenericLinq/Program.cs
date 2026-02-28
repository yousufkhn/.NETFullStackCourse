using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { EmpId = 1001, FirstName = "Malcolm", LastName = "Daruwala", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" });
            empList.Add(new Employee { EmpId = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 08, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" });
            empList.Add(new Employee { EmpId = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" });
            empList.Add(new Employee { EmpId = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" });
            empList.Add(new Employee { EmpId = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" });
            empList.Add(new Employee { EmpId = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" });
            empList.Add(new Employee { EmpId = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" });
            empList.Add(new Employee { EmpId = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" });
            empList.Add(new Employee { EmpId = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" });
            empList.Add(new Employee { EmpId = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" });


            // details of all the employee
            Console.WriteLine("\n Details of all the employees");
            empList.ForEach(e => Console.WriteLine($"{e.EmpId} {e.FirstName} {e.LastName} {e.Title} {e.DOB.Date} {e.DOJ}"));

            // details of all the employees not from mumbai
            Console.WriteLine("\nEmployees not in Mumbai");
            empList.Where(e => !e.City.Equals("Mumbai")).ToList()
                .ForEach(e => Console.WriteLine($"{e.EmpId} {e.FirstName} {e.LastName} {e.Title}  {e.City}"));

            // details of all the employees whose title is AsstManager
            Console.WriteLine("\nEmployees whole title is AsstManager");
            empList.Where(e => e.Title.Equals("AsstManager")).ToList()
                .ForEach(e => Console.WriteLine($"{e.EmpId} {e.FirstName} {e.LastName} {e.Title} {e.DOB} {e.DOJ}"));

            // details of employees whose last name starts with s
            Console.WriteLine("\nEmployees whose last name starts with s");
            empList.Where(e => e.LastName.StartsWith("S")).ToList()
                .ForEach(e => Console.WriteLine($"{e.EmpId} {e.FirstName} {e.LastName} {e.Title} {e.DOB} {e.DOJ}"));

            // details of employees who joined before 1/1/2015
            Console.WriteLine("\nEmployees who joined before 1/1/2015");
            var joiningDate = new DateTime(2015, 1, 1);
            empList.Where(e => e.DOJ < joiningDate).ToList()
                .ForEach(e => Console.WriteLine($"{e.EmpId} {e.FirstName} {e.LastName} {e.Title} {e.DOJ}"));

            // list of employees who dob is after 1/1/1990
            Console.WriteLine("\n Employees with dob after 1/1/1990");
            var doBirth = new DateTime(1990, 1, 1);
            empList.Where(e=>e.DOB > doBirth).ToList()
                .ForEach(e => Console.WriteLine($"{e.EmpId} {e.FirstName} {e.LastName} {e.Title} {e.DOB}"));

            Console.WriteLine("\n Employees who are either Consultatnt or associate");
            empList.Where(e => e.Title.Equals("Consultant") || e.Title.Equals("Associate")).ToList()
                .ForEach(e => Console.WriteLine($"{e.EmpId} {e.FirstName} {e.LastName} {e.Title}"));

            Console.WriteLine("\n Total Number of employees");
            Console.WriteLine($"Total number of employees{empList.Count}");

            Console.WriteLine("\n Total number of employees from chennai : " + empList.Count(e=>e.City.Equals("Chennai")).ToString());

            Console.WriteLine("\n Highest employee id from the list : " + empList.Max(e => e.EmpId).ToString());

            //Console.WriteLine("\n Number of employees joined after 1/1/2015 { empList.Where(e=>e.DOJ > new DateTime(1/1/2015)).ToList().ForEach(e=>Console.WriteLine($"{e.DOJ}"))};

            empList.Where(e=>!e.Title.Equals("Associate")).ToList()
                .ForEach(e => Console.WriteLine($"{e.EmpId} {e.FirstName} {e.LastName} {e.Title}"));

            var result = empList.GroupBy(e => e.City)
                .Select(e => new
                {
                    city = e.Key,
                    count = e.Count()
                });

            foreach(var res in result)
            {
                Console.WriteLine($"{res.city} : {res.count}");
            }

            var result2 = empList.GroupBy(e => new { e.City, e.Title })
                .Select(e => new
                {
                    city = e.Key.City,
                    title = e.Key.Title,
                    count = e.Count()
                }).ToList();

            foreach (var res in result2)
            {
                Console.WriteLine($"{res.city} {res.title}: {res.count}");
            }

            var youngest = empList.Min(e => new DateTime(2026,02,27) - e.DOB);
            Console.WriteLine(youngest);







        }
    }
}
