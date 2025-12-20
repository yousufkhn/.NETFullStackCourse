using System;

class Circle
{
    public static void CalculateArea()
    {
        Console.Write("Enter the radius : ");

        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("The area is : " + area);
    }
}