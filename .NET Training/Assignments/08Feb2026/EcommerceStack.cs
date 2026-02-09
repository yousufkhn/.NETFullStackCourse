namespace EcommerceStack
{
    public class Program
    {
        public static Stack<Order> OrderStack = new Stack<Order>();
        public static void Main(string[] args)
        {
            Order orderObj = new Order();

            // Get input from user
            int orderId = int.Parse(Console.ReadLine());
            string customerName = Console.ReadLine();
            string item = Console.ReadLine();

            // Add order
            OrderStack = orderObj.AddOrderDetails(orderId, customerName, item);

            // Get most recent order details
            Console.WriteLine(orderObj.GetOrderDetails());

            // Remove most recent order
            OrderStack = orderObj.RemoveOrderDetails();

            // Display remaining orders count
            Console.WriteLine(OrderStack.Count);
        }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string Item { get; set; }

        public Order(){}

        public Order(int orderId,string customerName,string item)
        {
            OrderID = orderId;
            CustomerName = customerName;
            Item = item;
        }

        public Stack<Order> AddOrderDetails(int orderId, string customerName,string item)
        {
            Program.OrderStack.Push(new Order(orderId,customerName,item));
            return Program.OrderStack;
        }

        public string GetOrderDetails()
        {
            return $"{Program.OrderStack.Peek().OrderID} {Program.OrderStack.Peek().CustomerName} {Program.OrderStack.Peek().Item}";
        }

        public Stack<Order> RemoveOrderDetails()
        {
            Program.OrderStack.Pop();
            return Program.OrderStack;
        }
    }

}