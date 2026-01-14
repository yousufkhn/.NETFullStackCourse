using System;
using System.Collections.Generic;
using System.Text;

namespace CustomPropertyDemo
{
    internal class Customer
    {
        List<Order> orderList = null;
        
        public Customer()
        {
            orderList = new List<Order>();
        }
        public int CustID { get; set; }
        public string Name { get; set; }
        public Address BillingAddr { get; set; }
        public Address ShippingAddr { get; set; }
        public List<Order> MyOrders { 
            get
            {
                return orderList;
            }
            protected set {
                orderList = value;
            }
        }

    }
}
