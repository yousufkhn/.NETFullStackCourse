using System;

namespace Day2DemoConsole;

public class Student
{
    #region Fields
        int rollNo;
        string name;
        string addr;
    #endregion

    /// <summary>
    /// Default Constructor for Student class 
    /// </summary>
    public Student()
    {
        rollNo = 100;
        name = "John Doe(Dummy)";
        addr = "Dummy City";
    }

    public Student(int id, string name,string city)
    {
        rollNo = id;
        this.name = name;
        addr = city;
    }

    public void DisplayDetails(Student s)
    {
        Console.WriteLine("Roll No : {0} \nName : {1} \nAddress : {2}",s.rollNo,s.name,s.addr);
    }
}
