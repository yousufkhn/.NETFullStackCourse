namespace Assignment4;

abstract class Employee
{
    public string FirstName{get;set;}
    public string Surname{get;set;}
    public int EmployeeNumber{get;set;}

    public MedicalAid MedicalAid{get;set;}
    public abstract double CalculateEarnings();

}