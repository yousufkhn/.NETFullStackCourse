using System;

namespace PettyLedger
{
    public class Program
    {
        static void Menu()
        {
            System.Console.WriteLine("===========Welcome To Petty Ledger=============");
            System.Console.WriteLine("1. Add a Income Transaction");
            System.Console.WriteLine("2. Add a Expense Transaction");
            System.Console.WriteLine("3. Get Total Income");
            System.Console.WriteLine("4. Get Total Expense");
            System.Console.WriteLine("5. Exit");

            System.Console.Write("Enter the option you want to choose : ");
        }
        public static void Main(string[] args)
        {
            /// This is the Test case mentioned in the Question
            /// Test case starts here (uncomment to test)

            // Ledger<IncomeTransaction> incomeLegr = new Ledger<IncomeTransaction>();

            // IncomeTransaction inTran1 = new IncomeTransaction(101,new DateTime(2004,12,1),500,"Income","Salary");
            // incomeLegr.AddEntry(inTran1);

            // Ledger<ExpenseTransaction> expenseLegr = new Ledger<ExpenseTransaction>();

            // ExpenseTransaction exTran1 = new ExpenseTransaction(101,new DateTime(2004,12,1),20,"Stationery","Expense");
            // ExpenseTransaction exTran2 = new ExpenseTransaction(101,new DateTime(2004,12,1),15,"Team Snacks","Expense");

            // expenseLegr.AddEntry(exTran1);
            // expenseLegr.AddEntry(exTran2);

            // System.Console.WriteLine("Total spent " + expenseLegr.CalculateTotal());
            // System.Console.WriteLine("Total received " + incomeLegr.CalculateTotal());

            /// Test case ends here
            /// =================================================================================================
            



            Ledger<IncomeTransaction> incomeLegr = new Ledger<IncomeTransaction>();
            Ledger<ExpenseTransaction> expenseLegr = new Ledger<ExpenseTransaction>(); 
             

            while (true)
            {
                Menu();
                int input = Int32.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1 :
                        {
                            IncomeTransaction inTran;

                            System.Console.Write("Enter the Tran ID : ");
                            int id = Int32.Parse(Console.ReadLine());

                            System.Console.Write("Enter the Date : ");
                            DateTime date = DateTime.Parse(Console.ReadLine());

                            System.Console.Write("Enter the Income Amount : ");
                            float amount = float.Parse(Console.ReadLine());

                            System.Console.Write("Enter the Description: ");
                            string description = Console.ReadLine();

                            System.Console.Write("Enter the category: ");
                            string category = Console.ReadLine();

                            inTran = new IncomeTransaction(id,date,amount,description,category);
                            incomeLegr.AddEntry(inTran);
                            break;
                        }
                    case 2:
                        {
                            ExpenseTransaction exTran;

                            System.Console.Write("Enter the Tran ID : ");
                            int id = Int32.Parse(Console.ReadLine());

                            System.Console.Write("Enter the Date in this format(2024,12,12) : ");
                            DateTime date = DateTime.Parse(Console.ReadLine());

                            System.Console.Write("Enter the Expense Amount : ");
                            float amount = float.Parse(Console.ReadLine());

                            System.Console.Write("Enter the Description: ");
                            string description = Console.ReadLine();

                            System.Console.Write("Enter the category: ");
                            string category = Console.ReadLine();

                            exTran = new ExpenseTransaction(id,date,amount,description,category);
                            expenseLegr.AddEntry(exTran);
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Total Income: " + incomeLegr.CalculateTotal());
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("Total Expense: " + expenseLegr.CalculateTotal());
                            break;
                        }
                    case 5:
                        {
                            return;
                        }
                    default :
                        {
                            break;
                        }
                }
            }



            
        }
    }
}