using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareBillProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commodities = new List<Commodity>()
            {
                new Commodity(CommodityCategory.Furniture,"Bed",2,50000),
                new Commodity(CommodityCategory.Grocery,"Flour",5,80),
                new Commodity(CommodityCategory.Service,"Insurance",8,8500),
            };

            var prepareBill = new PrepareBill();
            prepareBill.SetTaxRates(CommodityCategory.Furniture, 18);
            prepareBill.SetTaxRates(CommodityCategory.Grocery, 5);
            prepareBill.SetTaxRates(CommodityCategory.Service, 12);

            var billAmount = prepareBill.CalculateBillAmount(commodities);
            Console.WriteLine(billAmount);
        }
    }
}
