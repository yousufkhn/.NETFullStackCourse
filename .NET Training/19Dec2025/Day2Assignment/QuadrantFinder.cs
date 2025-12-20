class QuadrantFinder
{
    public static void FindQuadrant()
    {
        Console.Write("Enter space separated coordinates (x y) : ");
        string input = Console.ReadLine();
        string[] coordinatesArr = input.Split(" ");
        int x = Int32.Parse(coordinatesArr[0]);
        int y = Int32.Parse(coordinatesArr[1]);

        if(x > 0)
        {
            if(y > 0)
            {
                Console.WriteLine("First Quadrant");
            }
            else
            {
                Console.WriteLine("Fourth Quadrant");                
            }
        }
        else
        {
            if(y > 0)
            {
                Console.WriteLine("Second Quadrant");
            }
            else
            {
                Console.WriteLine("Third Quadrant");
            }
        }
    }
}