class AdmissionEligibily
{
    public static void isEligible()
    {
        Console.Write("Enter Math Marks : ");
        int math = Int32.Parse(Console.ReadLine());

        Console.Write("Enter Phys Marks : ");
        int phys = Int32.Parse(Console.ReadLine());

        Console.Write("Enter Chem Marks : ");
        int chem = Int32.Parse(Console.ReadLine());

        if(
            (math >= 65 && phys >= 55 &&  chem >= 50)
             && 
             ((math+phys+chem >= 180) || (math+phys >= 140) )
            )
        {
            Console.WriteLine("Positive");
        }
        else
        {
            Console.WriteLine("Negative");
        }


    }
}