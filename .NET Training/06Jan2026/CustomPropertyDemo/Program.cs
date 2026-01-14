namespace CustomPropertyDemo
{
    /// <summary>
    /// use structures when no need of inheritance and more, 
    /// </summary>
    //struct Customer1 // Value type in Csharp, stored in stack 
    //{
       
    //    public int ID { get; set; }
    //    public string Name { get; set; } 

    //    // stucture cannot have a destructure because its value type so no need to deallocate memory


    //}

    public class Program
    {
        public static void Main(string[] args)
        {
            Customer custObj = new Customer();

            //Customer1 cust1;

            custObj.CustID = 101;
            custObj.Name = "Test";
            // init the shippingAddr
            custObj.ShippingAddr = new Address();
            custObj.ShippingAddr.FlatNo = 1802;
            custObj.ShippingAddr.BuildingName = "Test";
            custObj.ShippingAddr.Street = "Lane 1";
            custObj.ShippingAddr.Locality = "wakad";
            custObj.ShippingAddr.City = "Pune";

            //1 customer have many orders

            custObj.MyOrders = new List<Order>()
            {
                // datetime is a structure
                new Order{OrderID = 1001,OrderDate = new DateTime(2004,01,13),Amount = 1000000000},
                new Order{OrderID = 1002,OrderDate = new DateTime(2004,01,14),Amount = 2000000000},
                new Order{OrderID = 1003,OrderDate = new DateTime(2004,02,15),Amount = 630000000},
                new Order{OrderID = 1004,OrderDate = new DateTime(2004,12,16),Amount = 104400000},
            };

        }
    }
}