
class ElectricityBill
{
    public static void CalculateBill()
    {
        Console.Write("Enter the number of units used: ");
        int units = Int32.Parse(Console.ReadLine());
        double cost = 0;
        if(units <= 199)
        {
            cost = units * 1.20;
        }
        else if(units >199 && units <= 400)
        {
            cost += 199 * 1.20;
            units -=199;
            cost += units*1.50;
        }
        else if(units >400 && units <= 600)
        {
            cost += 199 * 1.20;
            cost += 200 * 1.50;
            units -= 400;
            cost += units * 1.80;
        }
        else if( units > 600)
        {
            cost += 199 * 1.20;
            cost += 200 * 1.50;
            cost += 200 * 1.80;
            units -= 600;
            cost += units * 2.00;
            cost *= 1.15; 
        }
        Console.WriteLine(cost);
    }
}