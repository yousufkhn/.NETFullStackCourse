using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupplesDemo
{
    internal class Program
        
    {
        
        static void CountryPopulationList()
        {
            var listCountryPopulation = new List<Tuple<int, string, string>>
            {
                Tuple.Create(1, "Germany", "83 Million"),
                Tuple.Create(2, "USA", "328 Million"),
                Tuple.Create(3, "France", "66 Million"),
                Tuple.Create(4, "Spain", "46 Million"),
                Tuple.Create(5,"India","1,417 million")
            };

            var listCountryPopulation1 = new List<Tuple<int, string, string>>();
            listCountryPopulation1.Add(new Tuple<int, string, string>(1, "Germany", "83 Million"));
            listCountryPopulation1.Add(new Tuple<int, string, string>(2, "USA", "328 Million"));
            listCountryPopulation1.Add(new Tuple<int, string, string>(3, "France", "66 Million"));
            listCountryPopulation1.Add(new Tuple<int, string, string>(4, "Spain", "46 Million"));
            listCountryPopulation1.Add(new Tuple<int, string, string>(5, "India", "1,417 Million"));

            foreach (Tuple<int, string, string> tuple in listCountryPopulation)
            {
                Console.WriteLine(tuple.Item1 + " " + tuple.Item2 + " " + tuple.Item3);
            }
            Console.ReadLine();
        }

        static void EmployeeTupleDemo()
        {
            var empList = new List<(int EmpID, string Name, string Lang)>();
            empList.Add((101, "Alok", "Java"));
            empList.Add((102, "Riya", "DotNet"));
            empList.Add((103, "Rajat", "Python"));
            empList.Add((104, "Sneha", "CPP"));

            foreach ((int, string, string) tuple in empList)
            {
                Console.WriteLine(tuple.Item1 + " " + tuple.Item2 + " " + tuple.Item3);
            }

            // Search for a employee with a specific ID
            int searchId = 103;
            var employee = empList.FirstOrDefault(p => p.EmpID == searchId);

            if (employee != default)
            {
                Console.WriteLine($"\nFound: Id={employee.EmpID}, Name={employee.Name}, Programming Lang={employee.Lang}\n");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }

            // Search for a employee with a specific name
            string searchName = "Riya";
            var employeeByName = empList.FirstOrDefault(e => e.Name == searchName);

            if (employeeByName != default)
            {
                Console.WriteLine($"Found: Id={employeeByName.EmpID}, Name={employeeByName.Name}, Programming Lang={employeeByName.Lang}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }

        }
        static void Main(string[] args)
        {
            // EmployeeTupleDemo();
            //TuppleCRUD.TuppleCRUDMain();
            TuppleSearchSortDemo.TuppleSearchSortMain();
           
            Console.ReadLine();

        }
    }
}
