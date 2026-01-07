using System;

namespace PettyLedger
{
    public class Ledger<T> where T : Transaction
    {
        internal List<T> transactions;

        public Ledger()
        {
            transactions = new List<T>();
        }

        public bool AddEntry(T entry)
        {
            try
            {
                transactions.Add(entry);
                return true;
            }
            catch(Exception e)
            {
                System.Console.WriteLine("Catched an exception " + e);
                return false;
            }
        }

        public List<T> GetTransactionsByDate(DateTime date)
        {
            return transactions.FindAll(t => t.TransactionDate == date);
        }

        public float CalculateTotal()
        {
            float total = 0;
            foreach(T tran in transactions)
            {
                total += tran.Amount;
            }
            return total;
        }
    }
}