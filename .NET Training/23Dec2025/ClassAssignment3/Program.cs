using System;

namespace CandyAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Candy myCandy = new Candy();

            while (true)
            {
                System.Console.WriteLine("Lets pick a candy shall we");
                System.Console.Write("Pick a flavour (Strawberry,Lemon,Mint) or (exit) to exit : ");
                string input = Console.ReadLine();
                if (input == "exit") break;
                myCandy.Flavour = input;
                if (myCandy.ValidateCandyFlavour())
                {
                    System.Console.Write("Enter the quantity : ");
                    myCandy.Quantity = Int32.Parse(Console.ReadLine());

                    System.Console.Write("Enter the price per piece : ");
                    myCandy.PricePerPiece = Int32.Parse(Console.ReadLine());

                    CalculateDiscountedPrice(myCandy);
                    System.Console.WriteLine($"The discounted candy price is {myCandy.TotalPrice}");
                }
                else
                {
                    System.Console.WriteLine("Invalid Flavour try again");
                }

            }


        }

        public static Candy CalculateDiscountedPrice(Candy candy)
        {
            int totalPrice = candy.Quantity * candy.PricePerPiece;
            if (candy.Flavour == "Strawberry")
            {
                candy.TotalPrice = totalPrice - (totalPrice * 0.15);
            }
            else if (candy.Flavour == "Lemon")
            {
                candy.TotalPrice = totalPrice - (totalPrice * 0.10);
            }
            else
            {
                candy.TotalPrice = totalPrice - (totalPrice * 0.05);
            }
            return candy;
        }
    }
}