using System;

namespace PettyLedger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ledger<IncomeTransaction> incomeLegr = new Ledger<IncomeTransaction>();

            IncomeTransaction inTran1 = new IncomeTransaction(101,new DateTime(2004,12,1),500,"Income","Salary");
            incomeLegr.AddEntry(inTran1);

            Ledger<ExpenseTransaction> expenseLegr = new Ledger<ExpenseTransaction>();

            ExpenseTransaction exTran1 = new ExpenseTransaction(101,new DateTime(2004,12,1),20,"Stationery","Expense");
            ExpenseTransaction exTran2 = new ExpenseTransaction(101,new DateTime(2004,12,1),15,"Team Snacks","Expense");

            expenseLegr.AddEntry(exTran1);
            expenseLegr.AddEntry(exTran2);



            
        }
    }
}