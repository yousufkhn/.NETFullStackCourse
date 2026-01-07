using System;

namespace PettyLedger
{
    public class ExpenseTransaction : Transaction
    {
        // preferebly enum in category
        public string Category { get; set; }

        public ExpenseTransaction(int id, DateTime date, float amount, string description, string category)
        {
            TransactionID = id;
            TransactionDate = date;
            Amount = amount;
            Description = description;
            Category = category;
        }

        public override void GetSummary()
        {
            System.Console.WriteLine("Summary from Expense Transaction");
        }
    }
}