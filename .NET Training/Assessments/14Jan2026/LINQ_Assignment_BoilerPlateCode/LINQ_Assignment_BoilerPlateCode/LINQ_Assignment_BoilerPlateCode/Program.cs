
using LINQ_Assignment_BoilerPlateCode.DTOs;
using LINQ_Assignment_BoilerPlateCode.Models;
using LINQ_Assignment_BoilerPlateCode.Repos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment_BoilerPlateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // =======================
            // SAMPLE DATA
            // =======================
            var employees = EmployeeRepo.SeedEmployees();
            var projects = ProjectRepo.SeedProjects();

            Console.WriteLine("LINQ Scenario Boilerplate Loaded");

            // 1.1
            //List<Employee> list = GetHighEarningEmployees(employees);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Id + item.Name + item.Salary.ToString());
            //}

            // 1.2
            //List<string> list2 = GetEmployeeNames(employees);
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            // 1.3
            //Console.WriteLine(HasHREmployees(employees));

            // 2.1

            // 2.2
            //Console.WriteLine(GetHighestPaidEmployee(employees).Salary);

            // 2.3
            List<Employee> list = SortEmployeesBySalaryAndName(employees);
            foreach (var item in list)
            {
                Console.WriteLine(item.Id + item.Name + item.Salary.ToString());
            }

        }

        // =====================================================
        // 🟢 SECTION 1 – HR ANALYTICS
        // =====================================================

        // TODO 1.1: Get employees earning more than 60,000
        static List<Employee> GetHighEarningEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.FindAll(e => e.Salary > 60000);
        }

        // TODO 1.2: Get list of employee names only
        static List<string> GetEmployeeNames(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.Select(e => e.Name).ToList();
        }

        // TODO 1.3: Check if any employee belongs to HR department
        static bool HasHREmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.Any(e => e.Department == "HR");
        }

        // =====================================================
        // 🟡 SECTION 2 – MANAGEMENT INSIGHTS
        // =====================================================

        // TODO 2.1: Get department-wise employee count
        static List<DepartmentCount> GetDepartmentWiseCount(List<Employee> employees)
        {
            //TODO: Write LINQ query here
            return employees.GroupBy(e => e.Department)
                .Select(s => new DepartmentCount { Department = s.Key, Count = s.Count() }).ToList();

        }

        // TODO 2.2: Find the highest paid employee
        static Employee GetHighestPaidEmployee(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.Find(e => e.Salary == employees.Max(f => f.Salary));
                
        }

        // TODO 2.3: Sort employees by Salary (DESC), then Name (ASC)
        static List<Employee> SortEmployeesBySalaryAndName(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.OrderByDescending(e => e.Salary).ThenBy(f => f.Name).ToList();
        }

        // =====================================================
        // 🔵 SECTION 3 – PROJECT & SKILL INTELLIGENCE
        // =====================================================

        // TODO 3.1: Join employees with projects
        static List<EmployeeProject> GetEmployeeProjectMappings(
            List<Employee> employees,
            List<Project> projects)
        {
            // TODO: Write LINQ query here
            return employees.Join(projects, e => e.Id, p => p.EmployeeId,
                (e, p) => new EmployeeProject { EmployeeName = e.Name, ProjectName = p.ProjectName }
                ).ToList();

        }

        // TODO 3.2: Find employees who are NOT assigned to any project
        static List<Employee> GetUnassignedEmployees(
            List<Employee> employees,
            List<Project> projects)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 3.3: Get all unique skills across the organization
        static List<string> GetAllUniqueSkills(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.SelectMany(e=>e.Skills).Distinct().ToList();
            
        }

        // =====================================================
        // 🔴 SECTION 4 – ADVANCED WORKFORCE ANALYTICS
        // =====================================================

        // TODO 4.1: Get top 3 highest-paid employees per department
        static List<DepartmentTopEmployees> GetTopEarnersByDepartment(
            List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.GroupBy(e => e.Department)
                .Select(s => new DepartmentTopEmployees 
                { 
                    Department = s.Key,
                    TopEmployees = s.OrderByDescending(z => z.Salary).Take(3).ToList() 
                }).ToList();
        }

        // TODO 4.2: Remove duplicate employees based on Id
        static List<Employee> RemoveDuplicateEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 4.3: Implement pagination
        static List<Employee> GetEmployeesByPage(
            List<Employee> employees,
            int pageNumber,
            int pageSize = 5)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }


    }
}
