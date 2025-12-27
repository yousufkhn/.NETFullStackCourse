using System;

namespace QuickMart
{
    public class Program
    {
        static SaleTransaction LastTransaction = null;
        static bool HasLastTransaction = false;
        static bool isApplicationRunning = true;

        static void CreateNewTransaction()
        {
            System.Console.WriteLine("Lets Create a New Transaction...");
            SaleTransaction saleTransactionObj = new SaleTransaction();
            
            // making sure if the invoice no is nott null or empty
            System.Console.Write("Enter the Invoice No : ");
            string? invoiceNo = Console.ReadLine();
            while(invoiceNo.IsWhiteSpace() || invoiceNo == null)
            {
                System.Console.WriteLine("Invoice No. can't be empty");
                System.Console.Write("Enter the Invoice No : ");
                invoiceNo = Console.ReadLine();
            }
            saleTransactionObj.InvoiceNo = invoiceNo;

            System.Console.Write("Enter the Customer Name : ");
            string? customerName = Console.ReadLine();
            saleTransactionObj.CustomerName = customerName;

            System.Console.Write("Enter the Item Name : ");
            string? itemName = Console.ReadLine();
            saleTransactionObj.ItemName = itemName;

            System.Console.Write("Enter the Quantity: ");
            int quantity = Int32.Parse(Console.ReadLine());
            while(quantity <= 0)
            {
                System.Console.WriteLine("Quantity should be more than 0 ");
                System.Console.Write("Enter the Quantity: ");
                quantity = Int32.Parse(Console.ReadLine());
            }
            saleTransactionObj.Quantity = quantity;

            System.Console.Write("Enter the Purchase Amount : ");
            decimal purchaseAmount = decimal.Parse(Console.ReadLine());
            while (purchaseAmount <= 0)
            {
                System.Console.WriteLine("Purchase Amount should be more than 0");
                System.Console.Write("Enter the Purchase Amount : ");
                purchaseAmount = decimal.Parse(Console.ReadLine());
            }
            saleTransactionObj.PurchaseAmount = purchaseAmount;

            System.Console.Write("Enter the Selling Amount : ");
            decimal sellingAmount = decimal.Parse(Console.ReadLine());
            while (sellingAmount < 0)
            {
                System.Console.WriteLine("Selling amount can't be negative");
                System.Console.Write("Enter the Selling Amount : ");
                sellingAmount = decimal.Parse(Console.ReadLine());
            }
            saleTransactionObj.SellingAmount = sellingAmount;


            saleTransactionObj.ComputeProfitLoss();  
            HasLastTransaction = true;
            LastTransaction = saleTransactionObj;
        }

        static void ViewLastTransaction()
        {
            if (HasLastTransaction)
            {
                System.Console.WriteLine("--------Last Transaction---------");
                System.Console.WriteLine($"InvoiceNO : {LastTransaction.InvoiceNo}");
                System.Console.WriteLine($"Customer : {LastTransaction.CustomerName}");
                System.Console.WriteLine($"Item : {LastTransaction.ItemName}");
                System.Console.WriteLine($"Quantity : {LastTransaction.Quantity}");
                System.Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount} ");
                System.Console.WriteLine($"Selling Amount : {LastTransaction.SellingAmount}");
                System.Console.WriteLine($"Status : {LastTransaction.ProfitOrLossStatus}");
                System.Console.WriteLine($"Profit loss amount : {LastTransaction.ProfitOrLossAmount}");
                System.Console.WriteLine($"Profit Margin : {LastTransaction.ProfitMarginPercent}");
            }
            else
            {
                System.Console.WriteLine("No Transaction Available, please create a new transaction first");
            }
        }

        public static void main(string[] args)
        {
            while (isApplicationRunning)
            {
                System.Console.WriteLine("=====================QuickMart Traders======================");
                System.Console.WriteLine("Enter One of these to interact:");
                System.Console.WriteLine("1. Create New Transaction ");
                System.Console.WriteLine("2. View Last Transaction ");
                System.Console.WriteLine("3. Calculate Profit/Loss");
                System.Console.WriteLine("4. Exit");
                System.Console.Write("Enter your input : ");
                string? input = Console.ReadLine();
                int choice = Int32.Parse(input);
                switch (choice)
                {
                    case 1:
                        {
                            CreateNewTransaction();
                            break;
                        }
                    case 2:
                        {
                            ViewLastTransaction();
                            break;
                        }
                    case 3:
                        {
                            LastTransaction.ComputeProfitLoss();
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("Application Closed Successfully");
                            isApplicationRunning = false;
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Please enter a valid response!");
                            break;
                        }
                }
            }
        }
    }
}