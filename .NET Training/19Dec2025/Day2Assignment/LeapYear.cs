class LeapYear
{
    public static void isLeap()
    {
        Console.Write("Enter the year : ");
        string? input = Console.ReadLine();

        if(int.TryParse(input, out int year))
        {
            if(year % 400 == 0)
            {
                Console.WriteLine("Leap Year!");
            }
            else if(year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}