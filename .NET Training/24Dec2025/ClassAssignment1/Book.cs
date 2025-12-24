using System;

namespace ClassAssignment1Space
{
    public class Book
    {
        public string Title{get;set;}
        public string Author{get;set;}
        public int NumPages{get;set;}
        public DateTime DueDate{get;set;}
        public DateTime ReturnedDate{get;set;}

        public Book(){}

        public Book(string title,string author,int numPages,DateTime dueDate,DateTime returnedDate)
        {
            this.Title = title;
            this.Author = author;
            this.NumPages = numPages;
            this.DueDate = dueDate;
            this.ReturnedDate = returnedDate;
        }

        public double AveragePagesReadPerDay(int daysToRead)
        {
            return (double)NumPages/daysToRead;
        }

        public double CalculateLateFee(double dailyLateFeeRate)
        {
            TimeSpan lateTime = ReturnedDate - DueDate;
            int lateDays = lateTime.Days;

            return (double)dailyLateFeeRate * lateDays;

        }
    }
}