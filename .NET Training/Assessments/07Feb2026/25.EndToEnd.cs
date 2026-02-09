using System.Linq;

namespace EndToEnd
{
    public class Program
    {
        public static void Main(String[] args)
        {
            
        }
    }

    public class Customer
    {
        public int CustID { get; set; }
        public string CustName { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Stock { get; set; }

        public void ReduceStock(int quantity)
        {
            if (quantity > Stock)
            {
                throw new InvalidOperationException("Insufficient Stock");
            }
            Stock -= quantity;
        }
    }

    public class Order
    {
        public int InvoiceNo { get; set; }
        public int CustID { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public bool IsPlaced{get; private set;}

        public void AddItem(Product product, int quantity)
        {
            if (IsPlaced)
            {
                throw new InvalidOperationException("Cannot modify placed order");
            }
            if (quantity <= 0)
            {
                throw new InvalidOperationException("Invalid Quantity");
            }
            Items.Add( new OrderItem
            {
                Product = product,
                Quantity = quantity
            });
        }

        public decimal CalculateTotal()
        {
            return Items.Sum(i => i.GetTotal());
        }

        public void PlaceOrder()
        {
            foreach(var item in Items)
            {
                item.Product.ReduceStock(item.Quantity);
            }
            IsPlaced = true;
        }


    }
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity {get;set;}

        public decimal GetTotal()
        {
            return Product.ProductPrice * Quantity;
        }
    }

    public class Payment
    {
        public int OrderID { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaymentDone { get; set; }

        public void MakePayment(decimal paymentAmount)
        {
            if(paymentAmount != Amount)
            {
                throw new InvalidOperationException("Incorrect payment amount");
            }
            IsPaymentDone = true;
        }
    }
}