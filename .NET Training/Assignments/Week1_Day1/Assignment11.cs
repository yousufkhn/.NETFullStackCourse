using System;

namespace Assignment11Space
{
    public class Company
    {
        public int EmpCount{get;}

        public Employee[] Employees{get;set;}


    }

    public class Employee
    {
        public string EmpDesign{get;set;}
        public int EmpId{get;set;}
        public string EmpName{get;set;}

    }
}