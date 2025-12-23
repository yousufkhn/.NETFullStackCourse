using System;

namespace CakeAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cake cake = new Cake();

            Console.WriteLine("Enter the flavour");
            cake.Flavour = Console.ReadLine();

            Console.WriteLine("Enter the quantity in kg");
            cake.QuantityInKg = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per kg");
            cake.PricePerKg = double.Parse(Console.ReadLine());

            try
            {
                cake.CakeOrder();
                System.Console.WriteLine(cake.CalculatePrice());

            }
            catch(InvalidFlavourException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch(InvalidQuantityException e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}