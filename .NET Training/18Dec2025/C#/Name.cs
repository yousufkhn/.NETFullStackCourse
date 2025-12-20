using System;

class Name
{
    public static void PrintName()
    {
        Console.Write("Enter your Name : ");
        string? name = Console.ReadLine();

        Console.WriteLine("Hello ," + name + "!");
    }
}