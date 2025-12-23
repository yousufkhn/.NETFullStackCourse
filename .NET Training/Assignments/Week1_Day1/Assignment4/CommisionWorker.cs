namespace Assignment4;
class CommisionWorker : Employee
{
    public double FlatSalary{get;set;}
    public double SalesPercent{get;set;}
    public double MonthlySales{get;set;}

    public override double CalculateEarnings()
    {
        return FlatSalary + SalesPercent / 100 * MonthlySales;
    }
}