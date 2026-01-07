using System;
using System.Collections.Generic;
using System.Text;

namespace CustomPropertyDemo
{
    internal class PrimeCustomer : Customer
    {
        public List<Order> MyPrimeOrders { //write only property
            set
            {
                MyOrders = value;
            }
        }
    }
}
