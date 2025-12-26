using System;

namespace ClassAssignment2Space
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CabDetails myCab = new CabDetails();
            System.Console.WriteLine("===CAB BOOKING===");

            System.Console.Write("Enter the booking id: ");
            myCab.BookingID = Console.ReadLine();
            
            System.Console.WriteLine("Enter the cab type(in lower case) : ");
            myCab.CabType = Console.ReadLine();

            System.Console.WriteLine("Enter the distance in km: ");
            myCab.Distance = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the waiting time in mins : ");
            myCab.WaitingTime = Int32.Parse(Console.ReadLine());

            if (!myCab.ValidateBookingID())
            {
                System.Console.WriteLine("The booking id is not correct");
            }
            else
            {
                System.Console.WriteLine(myCab.CalculateFareAmount());
            }



            
        }
    }
}