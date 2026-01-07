using LPU_BL;
using System;
using LPU_Entity;
using LPU_Exceptions;

namespace LPU_UI
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("            Student Management System             ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Search Student By ID");
            Console.WriteLine("2. Search Student By Name");
            Console.WriteLine("3. Add Student Details");
            Console.WriteLine("4. Update Student Details");
            Console.WriteLine("5. Drop Student Details");
            Console.WriteLine("6. Exit");
        }
        public static void Main(string[] args)
        {
            StudentBL sblObj = null;
            sblObj = new StudentBL();
            do
            {
                Menu();
                int choice = 0;
                Console.Write("Please Enter Your Choice : ");
                choice = Int32.Parse(Console.ReadLine());

                
                switch (choice)
                {
                    case 1: // Search Student by ID
                        {
                            int id = 0;
                            try
                            {
                                Console.Write("\tEnter Student ID for Search : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Student sObj = sblObj.SearchStudentByID(id);
                                
                                if(sObj != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("ID\t | Name\t | Course\t | Address\t");
                                    Console.ForegroundColor= ConsoleColor.Blue;
                                    Console.WriteLine("====================================");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"{sObj.StudentID}\t|{sObj.Name}\t|{sObj.Course}\t|{sObj.Address}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            catch(LPUException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 2: // Search Student by Name
                        {
                            try
                            {
                                Console.Write("\t Enter Student Name for Search : ");
                                string name = Console.ReadLine();
                                List<Student> studList = sblObj.SearchStudentByName(name);

                                if (studList != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("ID\t | Name\t | Course\t | Address\t");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("====================================");

                                    foreach(Student student in studList)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine($"{student.StudentID}\t|{student.Name}\t|{student.Course}\t|{student.Address}");
                                    }
                                }
                            }
                            catch(LPUException e)
                            {
                                Console.WriteLine("We are coming soon...");
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("We are coming soon...");
                            }

                            break;
                        }
                    case 3: // Add Students
                        {
                            break;
                        }
                    case 4: // Modify Student Details
                        {
                            break;
                        }
                    case 5: // Drop Student Details
                        {
                            break;
                        }
                    case 6: // Exit the Apln.
                        {
                            return;
                        }
                    default:
                        break;
                }
            } while (true);
        }
    }
}