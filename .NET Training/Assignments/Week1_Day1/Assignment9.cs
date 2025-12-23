namespace Assignment9NameSpace;
public class Assignment9
{
    public static void Assignment9Main()
    {
        Customer c1 = new Customer(101, "Yousuf", "India");
        Customer c2 = new Customer(102, "Aaysha");
        Customer c3 = new Customer(103, "Raj", "India", 50000, "Savings");

        Console.WriteLine(c1.CustName + " " + c1.AccType);
        Console.WriteLine(c2.CustName + " " + c2.CustAddress);
        Console.WriteLine(c3.CustName + " " + c3.CustBalance);
    }
}

class Customer
{
    public string AccType{get;set;}
    public string CustAddress{get;set;}
    public double CustBalance{get;set;}
    public string CustName{get;set;}
    public int CustId{get;set;}

    public Customer()
    {
        CustAddress = "No Address";
        CustBalance =  0.0;
        AccType = "No Type";
    }

    public Customer(int id,string name,string address){
        CustId = id;
        CustName = name;
        CustAddress = address;
        CustBalance = 0.0;
        AccType = "Not Assigned";
    }
    public Customer(int id,string name)
    {
        CustId = id;
        CustName = name;
        CustAddress = "Not Provided";
        CustBalance = 0.0;
        AccType = "Not Assigned";
    }
    public Customer(int id, string name, string address,double balance,string type)
    {
        CustId = id;
        CustName = name;
        CustAddress = address;
        CustBalance = balance;
        AccType = type;
    }
}