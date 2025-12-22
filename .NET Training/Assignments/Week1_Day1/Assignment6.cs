class Assignment6
{
    public static void GetFeedback()
    {
        int n = 3;
        Customer[] customers =  new Customer[n];

        customers[0] = new Customer(3.0,"8585858585","Yousuf");
        customers[1] = new Customer(4.0,"8585858585","Aaysha");
        customers[2] = new Customer(2.5,"8585858585","Prettier");

        System.Console.WriteLine(Customer.GetAverageRating() + " out of 5");
    }
}

class Customer
{
    public double FeedbackRating{get;set;}
    public string MobileNumber{get;set;}
    public string Name{get;set;}

    // static fields to keep the customer count and current rating
    private static double currentFeedback = 0;
    private static int customerCount = 0;

    public Customer(double feedbackRating,string mobileNumber,string name)
    {
        FeedbackRating = feedbackRating;
        MobileNumber = mobileNumber;
        Name = name;

        currentFeedback +=feedbackRating;
        customerCount++;
    }

    public static double GetAverageRating()
    {
        if (customerCount == 0)
            return 0;

        return currentFeedback / customerCount;
    }
}