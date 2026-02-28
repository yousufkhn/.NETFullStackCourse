using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace MiniOrder
{
    public delegate void OrderProcessedHandler(string message);
    public class Order
    {
        public int Id{get;set;}
        public string CustomerEmail{get;set;}
        public List<string> Items{get;set;}
        public decimal TotalAmount {get;set;}
    }

    public class OrderProcessor
    {
        public event OrderProcessedHandler OrderProcessed;
        private List<Order> _orders = new List<Order>();

        public bool ProcessOrder(ref Order order,out string summary)
        {
            string emailRegex = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.(com|in)$";
            if (!Regex.IsMatch(order.CustomerEmail, emailRegex))
            {
                return false;
            }
            decimal total = order.Items.Sum(i=>500);
            order.TotalAmount = total;
            StringBuilder sb = new StringBuilder();
            sb.Append("This is summary");
            summary = sb.ToString();
            _orders.Add(order);
            OrderProcessed?.Invoke("Order Processed Successfully");
            return true;
        }

        public List<Order> GetHighValueOrders(decimal minAmount)
        {
            return _orders.Where(o=>o.TotalAmount>minAmount).ToList();
        }
    }
}