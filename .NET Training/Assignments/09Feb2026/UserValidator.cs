using System;
using System.Text.RegularExpressions;

namespace UserValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string emailPattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.(com|in)$";
            string phonePattern = @"^(\+91)?[0-9]{10}$";
            string passPattern  = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$%^&*()])(?=.*\d).{8,}$";

            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            bool isEmailValid = Regex.IsMatch(email, emailPattern);
            bool isPhoneValid = Regex.IsMatch(phone, phonePattern);
            bool isPassValid  = Regex.IsMatch(password, passPattern);

            Console.WriteLine("\nValidation Results:");

            Console.WriteLine(isEmailValid 
                ? "Email is valid" 
                : "Email is invalid");

            Console.WriteLine(isPhoneValid 
                ? "Phone number is valid" 
                : "Phone number is invalid");

            Console.WriteLine(isPassValid 
                ? "Password is valid" 
                : "Password is invalid");
        }
    }
}
