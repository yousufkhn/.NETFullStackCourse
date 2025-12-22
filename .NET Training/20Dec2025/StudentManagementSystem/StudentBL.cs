using System;
namespace StudentManagementSystem
{
    public class StudentBL // studentBuisenessLogic
    {
        Student sObj = null;
        public StudentBL()
        {
            sObj = new Student();
        }

        public void AcceptStudentDeatils()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  Student Management System  ");
            Console.WriteLine("=============================");

            Console.ForegroundColor = ConsoleColor.Cyan;

            try
            {

                Console.WriteLine("Enter your RollNo : ");
                sObj.RollNo = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter your Name : ");
                sObj.Name = Console.ReadLine();

                Console.WriteLine("Enter your Address : ");
                sObj.Address = Console.ReadLine();

                Console.WriteLine("Enter your Physics Marks : ");
                sObj.Phy = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter your Chemistry Marks : ");
                sObj.Chem = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter your Maths : ");
                sObj.Maths = Int32.Parse(Console.ReadLine());
                
            }
            catch(InvalidMarksException e)
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.Message);
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

        public int CalculateTotal()
        {
            sObj.Total = sObj.Phy + sObj.Chem + sObj.Maths;
            return sObj.Total;
        }

        public float CalculateAvg()
        {
            sObj.Perc= sObj.Total/3;
            return sObj.Perc;
        }

        public void calculateResult(out int myTotal, out float myPerc)
        {
            myTotal = sObj.Phy + sObj.Chem + sObj.Maths;
            myPerc = myTotal/3;
        }

    }
}