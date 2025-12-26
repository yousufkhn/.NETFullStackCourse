using System;
using System.Text.RegularExpressions;

namespace ClassAssignment2Space
{
    public class Cab
    {
        public string BookingID{get;set;}
        public string CabType{get;set;}
        public double Distance{get;set;}
        public int WaitingTime{get;set;}

    }

    public class CabDetails : Cab
    {
        public bool ValidateBookingID()
        {
            if (Regex.IsMatch(BookingID, @"^AC@\d{3}$"))
            {
                return true;
            }
            return false;
        }

        public double CalculateFareAmount()
        {
            int pricePerKM = PricePerKM(CabType);
            return Math.Floor((Distance * pricePerKM + (Math.Sqrt(WaitingTime)))*100)/100;
        }

        int PricePerKM(string cabType)
        {
            if(cabType == "hatchback")
            {
                return 10;
            }
            else if(cabType == "sedan")
            {
                return 20;
            }
            else if(cabType == "suv")
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }
    }
    

}