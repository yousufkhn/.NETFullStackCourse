using System;

public class Public
{
    public static void Main(string[] args)
    {
        // System.Console.WriteLine(AreaOfCircle());
        // System.Console.WriteLine(FeetToCM());
        System.Console.WriteLine(HeightCategorizer());
    }
    public static double AreaOfCircle()
    {
        System.Console.Write("Enter the radius : ");
        double radius = double.Parse(Console.ReadLine());

        return Math.Round(Math.PI * radius * radius,2);
    }

    public static double FeetToCM()
    {
        System.Console.WriteLine("Enter in feet : ");
        double feet = double.Parse(Console.ReadLine());
        
        return Math.Round(30.48 * feet , 2);
    }

    public static string HeightCategorizer()
    {
        System.Console.WriteLine("Enter your height : ");
        int height = Int32.Parse(Console.ReadLine());

        if(height < 150)
        {
            return "Short";
        }
        else if(height >= 150 && height < 180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }
}