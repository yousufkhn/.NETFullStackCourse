namespace Assignment10NameSpace;

public class TestShapes         
{
    public static void Test()
    {
        Circle shape1 = new Circle();
        shape1.Radius = 5;
        Console.WriteLine(shape1);

        Rectangle shape2 = new Rectangle();
        shape2.Width = 5;
        shape2.Length = 6;
        Console.WriteLine(shape2);
    }
}
abstract class Shape
{
    public string Color { get; set; }

    public bool Filled { get; set; }

    override public string ToString()
    {
        return "Shape";
    }
    public Shape()
    {
        Color = "Red";
        Filled = true;
    }
}

class Rectangle : Shape
{
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle()
    {
        Length = 1;
        Width = 1;
    }
    public double GetArea()
    {
        return Length * Width;
    }

    public double GetPerimeter()
    {
        return 2 * (Length + Width);
    }
    override public string ToString()
    {
        return $"Rectangle - Area {GetArea().ToString()}";
    }

}

class Square : Rectangle
{
    public override string ToString()
    {
        return $"Square - Area {GetArea().ToString()}";
    }
}

class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(){
        Radius = 1;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string ToString()
    {
        return $"Circle : Area -> {GetArea()}";
    }

}