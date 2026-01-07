// See https://aka.ms/new-console-template for more information
using RealEstateListing;

Console.WriteLine("Hello, World!");

RealEstateApp app = new RealEstateApp();

IRealEstate estate = new RealEstate();
estate.Description = "description";
estate.ID = 101;
estate.Location = "Kolkata";
estate.Price = 1000;
estate.Title = "Title";
app.AddListing(estate);

List<IRealEstate> list = app.GetListings();
foreach(IRealEstate item in list)
{
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.Price);
}
