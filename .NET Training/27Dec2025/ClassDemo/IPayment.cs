namespace CollectionsDemo;
interface IPayment
{
    void Pay(double amount);
}

sealed class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        System.Console.WriteLine("Cash Paid : " + amount);
    }
}

class CardPayment : IPayment
{
    public void Pay(double amount)
    {
        System.Console.WriteLine("Paid with Card : " + amount);
    }
}