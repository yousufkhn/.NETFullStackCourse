namespace EventsDemo
{
    public delegate void TransactionHandler(string type, decimal amount, decimal balance);
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.TransactionOccured += ShowTransaction;
            account.Balance = 5000;

            account.Deposit(500);
            account.WithDraw(600);
        }

        public static void ShowTransaction(string type,decimal amount,decimal balance)
        {
            System.Console.WriteLine($"{type} {amount} {balance}");
        }
    }


    public class BankAccount
    {
        public event TransactionHandler TransactionOccured;
        public decimal Balance { get; set; }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            TransactionOccured?.Invoke("Deposit",amount,Balance);
        }

        public void WithDraw(decimal amount)
        {
            Balance -= amount;
            TransactionOccured?.Invoke("Withdraw",amount,Balance);
        }
    }
}