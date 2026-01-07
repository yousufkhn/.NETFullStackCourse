using System;

namespace RealEstateListing
{
    public class RealEstate : IRealEstate
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }

        public RealEstate()
        {
            
        }

        public RealEstate(int id,string title,string description,int price,string location)
        {
            ID = id;
            Title = title;
            Description = description;
            Price = price;
            Location = location;            
        }
    }
}