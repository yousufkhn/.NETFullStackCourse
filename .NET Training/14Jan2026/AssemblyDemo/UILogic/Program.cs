using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary;

namespace UILogic
{
    [Doctor(Name ="Ravi",CheckedOn = "12/02/2025")]
    [Doctor(Name = "Shashi", CheckedOn = "12/02/2025")]

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st Number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            SomeLogic sl = new SomeLogic();
            Console.WriteLine($"The Sum of {num1} and {num2} is : " + sl.AddMe(num1, num2));
            
        }
    }
}
