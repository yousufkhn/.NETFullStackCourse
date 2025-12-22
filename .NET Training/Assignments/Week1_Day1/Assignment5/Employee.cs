namespace Assignment5;

class Employee
{
    private string empDept;
    private string empDesig;
    public int EmpId { get; set; }
    private string empName;

    public string EmpName
    {
        get
        {
            return empName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                System.Console.WriteLine("Error : Employee name cannot be empty or null");
            }
            else
            {
                empName = value;
            }
        }
    }

    public string EmpDesig
    {
        get { return EmpDesig; }
        set
        {
            if (value == "developer" || value == "tester" ||
                     value == "Lead" || value == "manager")
            {
                empDesig = value;
            }
            else
            {
                Console.WriteLine("Invalid designation");
            }
        }
    }

    public string EmpDept
    {
        get { return empDept; }
        set
        {
            if (value == "C2" || value == "TTG" ||
                value == "ITES" || value == "PES")
            {
                empDept = value;
            }
            else
            {
                Console.WriteLine("Invalid Dept");
            }
        }
    }
}