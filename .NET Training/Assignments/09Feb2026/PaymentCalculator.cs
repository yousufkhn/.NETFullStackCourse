public class Program
{
    public static void Main(string[] args)
    {
        
    }

    public void CalculateBill(ref decimal baseAmount,out decimal tax,out decimal discount,out decimal finalAmount)
    {
        if(baseAmount > 5000)
        {
            discount = baseAmount * 0.1;
        }
        else discount = 0;
        tax = (baseAmount - discount) * 0.18;

        finalAmount = baseAmount;
    }
}