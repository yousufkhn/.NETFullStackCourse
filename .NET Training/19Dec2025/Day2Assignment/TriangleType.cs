class TriangleType
{
    public static void CheckType()
    {
        Console.WriteLine("Lets check the triangle type, give us the length of the three sides of the triangle");
        Console.Write("Enter the length of the 1st side : ");
        int first = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the length of the 2nd side : ");
        int second = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the length of the 3rd side : ");
        int third = Int32.Parse(Console.ReadLine());

        if(first == second && second == third)
        {
            Console.WriteLine("Equilateral Triangle");
        }
        else if(first == second || second == third || first == third)
        {
            Console.WriteLine("Isosceles Triangle");
        }
        else
        {
            Console.WriteLine("Scalene Triangle");
        }
    }
}