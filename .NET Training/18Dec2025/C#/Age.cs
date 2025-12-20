class Age
{
    public static void IsAdult()
    {
        Console.Write("Enter age : ");
        string? input = Console.ReadLine();

        if(int.TryParse(input, out int age))
        {
            bool isAdult = age >= 18;
            Console.WriteLine("Adult ? " + isAdult);
        }
        else
        {
            Console.WriteLine("Invalid Age. Please enter a whole number.");
        }
    }
}