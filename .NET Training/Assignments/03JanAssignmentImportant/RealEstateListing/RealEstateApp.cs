using System;

namespace RealEstateListing
{
    public class RealEstateApp
    {
        private List<IRealEstate> listings;

        public RealEstateApp(){
            listings = new List<IRealEstate>();
        }

        public void AddListing(IRealEstate realEstate)
        {
            listings.Add(realEstate);
        }

        public void RemoveListing(int id)
        {
            listings.RemoveAll(r => r.ID == id);
        }

        public void UpdateListing(IRealEstate realEstate)
        {
            IRealEstate? realEst = listings.Find(p => p.ID.Equals(realEstate.ID));
            if (realEst != null)
            {
                realEst.Description = realEstate.Description;
                realEst.Location = realEstate.Location;
                realEst.Price = realEstate.Price;
                realEst.Title = realEstate.Title;
            }
        }

        public List<IRealEstate> GetListings()
        {
            return new List<IRealEstate>(listings);
        }

        public List<IRealEstate> GetListingsByLocation(string location)
        {
            return new List<IRealEstate>(listings.FindAll(p => p.Location.Equals(location)));
        }

        public List<IRealEstate> GetListingsByPriceRange(int minPrice,int maxPrice)
        {
            return new List<IRealEstate>(listings.FindAll(p=> p.Price < maxPrice && p.Price > minPrice));
        }       


    }
}