// See https://aka.ms/new-console-template for more information
using InterfaceDemoProject;

// Console.WriteLine("Demo on Interfaces!");

// IAdd m1 = new MathClass(); // User1 - Add

// IAddSub m2 = new MathClass(); // User2 - Add,Sub

// IAll m3 = new MathClass(); // User3 - All

// Only the required methods are exposed
// Factory design pattern

// Approach 1
Product pObj1 = new Product();
pObj1.ProdID = 101;
pObj1.Name = "Flask";
pObj1.Price = 850;

// Approach 2
// Object initializer
Product pObj2 = new Product()
{
    ProdID = 102,
    Name="Marker",
    Price=50,
};

// In Arraylist the element is stored in the form of object, boxing and unboxing happens and degrades the performance
// thats why we using list

//Collection Initializer
List<Product> prodList = new List<Product>()
{
    new Product()
{
    ProdID = 102,
    Name="Marker",
    Price=50,
},
    new Product()
{
    ProdID = 103,
    Name="Marker2",
    Price=50,
},    new Product()
{
    ProdID = 104,
    Name="Marker3",
    Price=50,
},    new Product()
{
    ProdID = 105,
    Name="Marker4",
    Price=50,
},    new Product()
{
    ProdID = 106,
    Name="Marker5",
    Price=50,
}
};

foreach (var item in prodList)
{   
    // string interpolation
    System.Console.WriteLine($"{item.ProdID}\t{item.Name}\t{item.Price}");
}

