using System;

namespace BikeRentalSpace
{
    public class Program
    {
        public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();
        public static void Main(string[] args)
        {
            BikeUtility bUtil = new BikeUtility();
            while (true)
            {
                System.Console.WriteLine("1. Add Bike Details");
                System.Console.WriteLine("2. Group Bike By Brand");
                System.Console.WriteLine("3. Exit");

                System.Console.WriteLine("Enter you Choice: ");
                int choice  = Int32.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    System.Console.Write("Enter the model : ");
                    string model = Console.ReadLine();

                    System.Console.Write("Enter the Brand: ");
                    string brand = Console.ReadLine();

                    System.Console.Write("Enter the price Per day : ");
                    int pricePerDay = Int32.Parse(Console.ReadLine());

                    bUtil.AddBikeDetails(model,brand,pricePerDay);

                }
                else if(choice == 2)
                {
                    var dictionary = bUtil.GroupBikesByBrand();

                    foreach(var item in dictionary)
                    {
                        System.Console.WriteLine($"Brand : {item.Key}");
                        foreach(Bike b in item.Value)
                        {
                            System.Console.WriteLine($"Bike : {b.Model} {b.PricePerDay} ");
                        }
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }

    public class Bike
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int PricePerDay { get; set; }
    }

    public class BikeUtility
    {
        public void AddBikeDetails(string model, string brand, int pricePerDay)
        {
            Bike bk = new Bike();
            bk.Model = model;
            bk.Brand = brand;
            bk.PricePerDay = pricePerDay;

            int count = Program.bikeDetails.Count;

            Program.bikeDetails.Add(count+1,bk);
        }

        public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
        {
            SortedDictionary<string,List<Bike>> groupedByBrand = new SortedDictionary<string,List<Bike>>();
            foreach(var item in Program.bikeDetails)
            {
                Bike bike = item.Value;
                if (!groupedByBrand.ContainsKey(bike.Brand))
                {
                    List<Bike> newList = new List<Bike>();
                    newList.Add(bike);
                    groupedByBrand.Add(bike.Brand,newList);
                }
                else
                {
                    List<Bike> list = groupedByBrand[bike.Brand];
                    list.Add(bike);
                    groupedByBrand[bike.Brand] = list;
                }
            }
            return groupedByBrand;
        }
    }
}