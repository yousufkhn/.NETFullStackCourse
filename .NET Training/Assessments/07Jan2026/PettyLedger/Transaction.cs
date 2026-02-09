using System;

namespace PettyLedger
{
    public abstract class Transaction : IReportable
    {
        public int TransactionID { get; set; }
        public DateTime TransactionDate {get;set;}
        public float Amount { get; set; }
        public string Description { get; set; }

        public abstract void GetSummary();
    }
}