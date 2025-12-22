namespace Assignment4;
class Manager : Employee
{
    public double MonthlySalary{get;set;}
    public Pension Pension{get;set;}

    public override double CalculateEarnings()
    {
        return MonthlySalary;
    }
}