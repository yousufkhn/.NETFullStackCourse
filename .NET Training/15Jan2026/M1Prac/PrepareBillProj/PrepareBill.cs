using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareBillProj
{
    internal class PrepareBill
    {
        private IDictionary<CommodityCategory, double> _taxRates;
        public PrepareBill() 
        {
            _taxRates = new Dictionary<CommodityCategory, double>();
        }

        public void SetTaxRates(CommodityCategory category, double taxRate)
        {
            if (_taxRates.ContainsKey(category))
            {
                _taxRates[category] = taxRate;
            }
            else
            {
                _taxRates.Add(category, taxRate);
            }
        }
        public double CalculateBillAmount(IList<Commodity> items)
        {
            double total = 0.0;
            foreach(var item in items)
            {
                if (!_taxRates.ContainsKey(item.Category))
                {
                    throw new ArgumentException();
                }
                else
                {
                    total += item.CommodityPrice * item.CommodityQuantity +  (((item.CommodityPrice * item.CommodityQuantity)* _taxRates[item.Category])/100);
                }
            }
            return total;
            float f = Convert.ToSingle(909099090912313);

        }
    }
}
