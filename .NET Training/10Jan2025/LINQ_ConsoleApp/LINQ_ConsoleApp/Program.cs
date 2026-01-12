using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ConsoleApp
{
    internal class Program
    {
        public static void LinqToObjectDemo()
        {
            int[] numArray = { 10, 2, 12, 34, 45, 65, 23, 66, 48, 8, 27 };

            string[] nameArray = { "Alok", "Rajat", "Yousuf", "Sumit", "Priya", "Ayush", "Harshita", "Himanshu","Mahi","Mandabi","Gaurav","Yash","Mahesh" };

            //foreach(var item in numArray)
            //{
            //    if(item %2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            // LINQ Query
            int dataToSearch = 12;

            //var result = from data in numArray
            //             where data % 2 == 0 && data > 20
            //             select data;
            //foreach(var r in result)
            //{
            //    Console.WriteLine(r);
            //}


            var result = nameArray.Where(n => n == "");
                        
        }
        
        public static void LinqToObjectDemoOnCustomType()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer(){CustomerID=101,Name="Alok",City="Pune"},
                new Customer(){CustomerID=102,Name="Alia",City="Mumbai"},
                new Customer(){CustomerID=103,Name="Yousuf",City="Kolkata"},
                new Customer(){CustomerID=104,Name="Aditya",City="Delhi"},
                new Customer(){CustomerID=105,Name="Divyanshu",City="Hyderabad"},
                new Customer(){CustomerID=106,Name="John Doe",City="Bangalore"},
                new Customer(){CustomerID=107,Name="Dheeraj",City="Chandigarh"},
                new Customer(){CustomerID=108,Name="Priya",City="Jammu"},
                new Customer(){CustomerID=101,Name="Meghna",City="Patna"},
                new Customer(){CustomerID=102,Name="Alia",City="Jalandhar"},
            };
            
            

            //var result = custList.
        }

        public static void LambdaLookup()
        {
            int[] numbers = { 1,1,1,1,2,2,2,3,3,3, 2, 3, 4, 5, 6, 7 };

            var query = numbers.ToLookup(i=> i % 2);

            foreach (IGrouping<int, int> group in query)
            {
                Console.WriteLine("Key : {0}", group.Key);

                foreach (int number in group)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static void LambdaLookupOnStudentList()
        {
            StudentRepo sRepo = new StudentRepo();

            List<Student> tempList = sRepo.GetAllStudents();

            var query = tempList.ToLookup(s => s.Gender == "Male");
            foreach(IGrouping<bool,Student> group in query)
            {
                int totFees = 0;
                //Console.WriteLine("Key : {0}",group.Key);
                if (group.Key)
                {
                    Console.WriteLine("Male Student Details below");
                }
                else
                {
                    Console.WriteLine("Female Student Details Below");
                }
                foreach (Student std in group)
                {
                    Console.WriteLine($"{std.Name}");
                    totFees += std.Fees;
                }
                Console.WriteLine($"Total Fees paid : {totFees}");

            }

            //var maleFeesPaid = tempList.Where(s => s.Gender == "Male").Sum();

        }
        static void Main(string[] args)
        {
            //LinqToObjectDemo();
            //LambdaLookup();
            LambdaLookupOnStudentList();

            StudentRepo sRepo = new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudents();
            var total = tempList.Select(s => s.Gender=="Male");

            Console.WriteLine(tempList.Sum(s => s.Gender == "Male"? s.Fees : 0));
            //Console.WriteLine(total);
        }
    }
}
