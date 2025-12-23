namespace Day4_OOP_Demo;

class Manager:Employee
{
    public int ManagerId { get; set; }
    public int Incentive { get; set; }

    new public int CalculateSalary(int sal)
    {
        //Net Salary = Salary+HRA+TA+DA-PF -> different for manager we shadowed the method inherited the method, and its hiding the method from the parent class - called as function shadowing
        int mySal = sal + 35000 + 12000 + 1500 - 2500;
        return  mySal;
    }

}