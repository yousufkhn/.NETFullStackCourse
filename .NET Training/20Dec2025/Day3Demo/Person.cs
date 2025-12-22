namespace Day3Demo;

internal class Person
{
    #region Fields
    string name;
    int age;


    #endregion

    public Person()
    {
        Console.WriteLine("Person Class Constructor Invoked");
    }

    ~Person()
    {
        Console.WriteLine("Person Class Destructor Invoked");
    }

    /// <summary>
    /// Display Method for demo purpose
    /// </summary>
    /// <param name="obj"> Object Variable</param>
    public void Display(object obj)
    {
        
    }
}
