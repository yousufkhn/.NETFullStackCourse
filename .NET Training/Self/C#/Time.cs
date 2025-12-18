using System;

class Time
{
    public static void SecToMin()
    {
        Console.Write("Enter seconds : ");

        int seconds = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(seconds/60);
        
    }
}