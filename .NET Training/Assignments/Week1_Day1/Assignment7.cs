namespace Assignment7NameSpace;
class Assignment7
{
    public static void RunAssignment7()
    {
        Customer cust = new Customer(122,"Yousuf","India","8582803723");

        Bank bank = new Bank();
        Bank.CustomerList.Add(cust);

        Customer verifiedCustomer = Agency.VerifyCustomer(cust);

        System.Console.WriteLine($"Customer status : {verifiedCustomer.CustStatus}");

        if(verifiedCustomer.CustStatus == "Green")
        {
            System.Console.WriteLine("Loan Approved");
        }
        else
        {
            System.Console.WriteLine("Loan Rejected");
        }


    }
}

class Bank
{
    public string Bankname{get;set;}
    public string BankAddress{get;set;}
    public string BankContactNo{get;set;}
    public static List<Customer> CustomerList{get;set;} = new List<Customer>();

    public Bank()
    {
        Bankname = "SBI";
        BankAddress = "India";
        BankContactNo = "88888888";
    }

    public Bank(string bankName, string bankAddress,string bankContactNo)
    {
        Bankname = bankName;
        BankAddress = bankAddress;
        BankContactNo = bankContactNo;
    }

    public void AddCustomer(Customer customer)
    {
        CustomerList.Add(customer);
    }
}

class Customer
{
    public int CustId{get;set;}
    public string CustName{get;set;}
    public string CustAddress{get;set;}
    public string CustMobileNo{get;set;}
    public string? CustStatus{get;set;}

    public Customer()
    {
        CustId = 123;
        CustName = "Yousuf";
        CustAddress = "India";
        CustMobileNo = "8585858585";
        CustStatus = null;
    }

    public Customer(int custId,string custName,string custAddress,string custMobileNo)
    {
        CustId = custId;
        CustName = custName;
        CustAddress = custAddress;
        CustMobileNo = custMobileNo;
        CustStatus = null;
        
    }
}

class Agency
{
    public string AgencyName{get;set;}
    public string AgencyAddress{get;set;}
    public string AgencyContactNumber{get;set;}

    public Agency()
    {
        AgencyName = "Agency 1";
        AgencyAddress = "India";
        AgencyContactNumber = "9999999999";
    }

    public Agency(string agencyName, string agencyAddress,string agencyContactNumber)
    {
        AgencyName = agencyName;
        AgencyAddress = agencyAddress;
        AgencyContactNumber = agencyContactNumber; 
        
    }

    public static Customer VerifyCustomer(Customer customerObj)
    {
        if(customerObj.CustId %2 == 0)
        {
            customerObj.CustStatus = "Green";
            return customerObj;
        }
        else
        {
            customerObj.CustStatus = "Red";
            return customerObj;
        }
    }
}