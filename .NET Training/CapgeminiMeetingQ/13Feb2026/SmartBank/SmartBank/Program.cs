using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreditRiskProcessor processor = new CreditRiskProcessor();


            Console.Write("Enter the Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.Write("Employment Type(Salaried/Self-Employed): ");
            string type = Console.ReadLine();

            Console.Write("Monthly Income : ");
            double income = Double.Parse(Console.ReadLine());

            Console.Write("Dues : ");
            int dues = Int32.Parse(Console.ReadLine());

            Console.Write("Credit score: ");
            int score = Int32.Parse(Console.ReadLine());

            Console.Write("Defaults : ");
            int defaults = Int32.Parse(Console.ReadLine());

            
            try
            {
                if(processor.ValidateCustomerDetails(age, type, income, dues, score, defaults))
                {
                    Console.WriteLine($"The credit limit is : {processor.CalculateCreditLimit(income, dues, score, defaults)}");
                }
            }
            catch(InvalidCreditDataException e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
