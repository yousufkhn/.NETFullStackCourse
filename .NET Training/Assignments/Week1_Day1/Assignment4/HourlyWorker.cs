namespace Assignment4;
class HourlyWorker : Employee
{
    public int HoursWorked{get;set;}
    public int WagePerHour{get;set;}

    public override double CalculateEarnings()
    {
        return HoursWorked*WagePerHour;   
    }
}