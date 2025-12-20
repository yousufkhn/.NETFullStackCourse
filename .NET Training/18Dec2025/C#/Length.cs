using System;

class Length
{
    public static void FeetToCM()
    {
        Console.Write("Enter in feet : ");
        string? input = Console.ReadLine();

        if(double.TryParse(input,out double feet))
        {
            Console.WriteLine(feet * 30.48);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}