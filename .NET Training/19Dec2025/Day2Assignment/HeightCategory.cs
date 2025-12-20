class HeightCategory
{
    public static void CheckHeight()
    {
        Console.Write("Enter your height pls(in cm) : ");
        string? input = Console.ReadLine();
        if(decimal.TryParse(input,out decimal height))
        {
            if(height < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if(height > 150 && height < 165)
            {
                Console.WriteLine("Average");
            }
            else if(height > 165 && height < 190)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Abnormal");
            }
        }
        else
        {
            Console.WriteLine("Please input a valid height");
        }
        
    }
}