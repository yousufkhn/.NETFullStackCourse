abstract class Shape
{
    public abstract double CalculateArea();
    public void DisplayType()
    {
        System.Console.WriteLine("This is a Shape");
    }

}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double r)
    {
        Radius = r;
    }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Rectangle(double l, double r)
    {
        Length = l;
        Breadth = r;
    }

    public override double CalculateArea()
    {
        return 2 * (Length + Breadth);
    }
}