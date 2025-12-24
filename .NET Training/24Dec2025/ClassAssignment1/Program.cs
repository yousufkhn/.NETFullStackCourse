using System;

namespace ClassAssignment1Space
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("===Library Management System===");

            System.Console.Write("Enter the title : ");
            string title = Console.ReadLine();

            System.Console.Write("Enter the author : ");
            string author = Console.ReadLine();

            System.Console.Write("Enter the number of pages: ");
            int pages = Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter the due date: ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Enter the return date : ");
            DateTime returnDate = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Enter the days to Read : ");
            int daysToRead = Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter the daily late feeRate : ");
            double dailyLateFeeRate = Int32.Parse(Console.ReadLine());

            Book myBook = new Book(title,author,pages,dueDate,returnDate);

            Console.WriteLine($"Average Pages To Read Per Day : {myBook.AveragePagesReadPerDay(150)}");
            Console.WriteLine($"Late Fee : {myBook.CalculateLateFee(30)}");
        }
    }
}