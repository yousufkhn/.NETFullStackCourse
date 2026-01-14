using System;

namespace MyKhata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> record = new Dictionary<string, int>
            {
                { "Milk", 100 },
                { "Tea", 50 },
                { "Coffee", 100 },
                { "Sugar", 50 },
                { "Salt", 200 }
            };

            Khata myKhata = new Khata(record);

            System.Console.WriteLine("Total Amount : " + myKhata.GetTotal());
            System.Console.WriteLine("Repeated Amount Count : " + myKhata.GetRepeatAmount());
            
        }
    }
}