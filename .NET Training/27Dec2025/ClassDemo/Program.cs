using System;

namespace CollectionsDemo
{
    public class Program
    {
        public void ArrayDemo()
        {
            int[] arrNum;
            arrNum = new int[5];

            int[] arrNum1 = new int[3]{10,20,30};

            string[] cities = {"Jalandhar","Mumbai","Delhi","Pune"};

            Customer[] customerArr = new Customer[2];

            customerArr[0].ID = 101;
            customerArr[0].Name = "Alok";
            customerArr[0].BillingAddress.FlatNo = "1802";
  
        }
        public static void Main(string[] args)
        {
            // List<Shape> shapes = new List<Shape>();

            // shapes.Add(new Circle(2));
            // shapes.Add(new Rectangle(2,4));

            // foreach(Shape s in shapes)
            // {
            //     s.DisplayType();
            //     System.Console.WriteLine("Area : " + s.CalculateArea());
            // }

            List<IPayment> payments = new List<IPayment>();
            
            payments.Add(new CashPayment());
            payments.Add(new CardPayment());

            foreach(IPayment p in payments)
            {
                p.Pay(500);
            }
        }
    }
}