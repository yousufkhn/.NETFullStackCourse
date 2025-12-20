class GradeDescription
{
    public static void DescribeGrade()
    {
        Console.Write("Enter the Grade: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "E":
            case "e":
                Console.WriteLine("Excellent");
                break;
            case "V":
            case "v":
                Console.WriteLine("Very Good");
                break;
            case "G":
            case "g":
                Console.WriteLine("Good");
                break;
            case "A":
            case "a":
                Console.WriteLine("Average");
                break;
            case "F":
            case "f":
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Please enter a valid grade");
                break;
        }
    }
}