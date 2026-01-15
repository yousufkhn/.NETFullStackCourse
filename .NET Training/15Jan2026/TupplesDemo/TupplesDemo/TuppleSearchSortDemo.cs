using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupplesDemo
{
    internal class TuppleSearchSortDemo
    {
       public static List<(int ProdId, string Name, int Price)> prodList = null;

         static TuppleSearchSortDemo()
        {
            prodList = new List<(int ProId, string Name, int Price)>
            {
                (10, "Sebamed Cream", 1500),
                (20, "Combiflam Tab", 25),
                (30, "Althrocin Tab", 120),
                (40, "Doms wax Color", 35),
                (50, "Moist Cream", 150),
                (60, "Dcold Tab", 15),
                (70, "Prasita A", 240),
                (80, "Disprin", 10),
                (90, "Asprin Tab", 25),
                (100, "HP Cruiser", 650),
                (110, "Vicks Vaporub", 25),
                (120, "Crocin Tab", 10),
                (130, "DiclowinPlus", 25),
            };          

        }

        public static void TuppleSearchSortMain()
        {
            //SearchProductByNameAndPrice("Althrocin Tab", 120);

            //SortProductByPriceThenName();

           // GroupProductByPriceAndCountThem();

            //AggregateFuncDemo();

           // JoinFuncDemo();

            Console.ReadKey();
                
        }




        public static void SearchProductByNameAndPrice(string name, int price)
        {

            // Search for a Product by name and Price
            string searchName = name;
            int searchPrice = price;
            var product = prodList.FirstOrDefault(p => p.Name== searchName && p.Price == searchPrice);

            if (product != default)
            {
                Console.WriteLine($"Found: Id={product.ProdId}, Name={product.Name}, Price={product.Price}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public static void SortProductByPriceThenName()
        {
            var sortedProduct = prodList.OrderBy(p => p.Price).ThenBy(p => p.Name);

            foreach (var product in sortedProduct)
            {
                Console.WriteLine($" Id={product.ProdId}, Name={product.Name}, Price={product.Price}");
            }
        }

        public static void GroupProductByPriceAndCountThem()
        {
            // Group by Price and count the number of Product with same Price
            var groupedProduct = prodList.GroupBy(p => p.Price)
                                      .Select(g => new { Price = g.Key, Count = g.Count() });

            foreach (var group in groupedProduct)
            {
                Console.WriteLine($"For Price: {group.Price}, Total Product Count is: {group.Count}");
            }
        }

        public static void AggregateFuncDemo()
        {
            // Calculate the average Product Price
            var averagePrice = prodList.Average(p => p.Price);
            Console.WriteLine($"Average Product Cost: {averagePrice}");

            // Find the oldest person
            var costlyProd = prodList.OrderByDescending(p => p.Price).First();
            Console.WriteLine($"Costliest Product \n\tProduct ID:{costlyProd.ProdId}, Name={costlyProd.Name}, Price={costlyProd.Price}");
        }

        public static void JoinFuncDemo()
        {
           var prodList = new List<(int ProId, string Name, int Price,int catID)>
            {
                (10, "DairyMilk", 10,1),
                (20, "Sunflower Oil", 145,2),
                (30, "Mustard Oil", 180,2),
                (40, "Falero 100gm", 75,1),
                (50, "Sony LED TV32", 25000,3),
                (60, "Groundnut Oil", 210,2),
                (70, "Tomato Ketchup", 120,4),
                (80, "Samsung Microwave", 10000,3),
                (90, "Mayoniese", 160,4),
                (100, "Hair Dryer", 650,3),
                (110, "Farrero Rocher", 285,1),
                (112, "Hersheys Chocolate", 200,1),


            };

            var catList = new List<(int CatId, string CatName)>
            {
                (1, "Confectionery"),
                (2, "Cooking Essential"),
                (3, "Electronics"),
                (4,"Sauce & Topping")
            };

            // Join prodList with catList based on Id
            var joinedData = from prod in prodList
                             join cat in catList on prod.catID equals cat.CatId
                             select new { prod.ProId, prod.Name, prod.Price, cat.CatName };

            foreach (var item in joinedData)
            {
                Console.WriteLine($"Id={item.ProId}, Name={item.Name}, Price={item.Price}, Category Name={item.CatName}");
            }
        }
    }
}
   