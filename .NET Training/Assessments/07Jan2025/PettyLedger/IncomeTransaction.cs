using System;

namespace PettyLedger
{
    public class IncomeTransaction : Transaction
    {
        // preferebly enum
        public string Source { get; set; }

        public IncomeTransaction(int id, DateTime date, float amount, string description, string source)
        {
            TransactionID = id;
            TransactionDate = date;
            Amount = amount;
            Description = description;
            Source = source;
        }

        public override void GetSummary()
        {
            System.Console.WriteLine("Summary from Income Transaction");
        }
    }
}