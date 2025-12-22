namespace Assignment4;
class Assignment4
{
    public static void ManageEmployees()
    {
        Employee manager1 = new Manager
        {
            FirstName = "Aaysha",
            Surname = "Khan",
            EmployeeNumber = 101,
            MonthlySalary = 60000,
            MedicalAid = new MedicalAid
            {
                MedicalAidNumber = 111,
                Dependents = 2,
                EmployeeContribution = 3000,
                CompanyContribution = 5000
            },
            Pension = new Pension
            {
                PensionNumber = 9001,
                Beneficiaries = "family",
                Amount = 10000,
                RetirementDate = new DateTime(2045,1,1)
            }
        };

        System.Console.WriteLine($"Manager Earnings : {manager1.CalculateEarnings()}");
    }
}