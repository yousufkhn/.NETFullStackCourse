public class Program
{
    public static void Main(string[] args)
    {
        Box<int> intBox = new Box<int>();
        intBox.Value = 10;
        intBox.Display();

        Box<string> stringBox = new Box<string>();
        stringBox.Value = "Hello";
        stringBox.Display();
    }
}

public class Box<T>
{
    public T Value;

    public void Display()
    {
        System.Console.WriteLine($"Generic Value from Box Class : {Value}");
    }
}