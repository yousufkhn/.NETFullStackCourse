namespace Day4_OOP_Demo;

abstract class Employee
{
    #region Properties

    public int EmployeeID{get;set;}
    public string Name{get;set;}

    public int BasicSal{get;set;}

    #endregion

    // marking base class method as virtual to be able to allow the method to be showdowed the the child class, there is a difference between shadowing and overrideing
    public int CalculateSalary(int sal)
    {
        //Net Salary = Salary+HRA+TA+DA-PF
        int mySal = sal + 15000 + 3000 + 1500 - 2500;
        return  mySal;
    }
}

// using System;

// // BASE CLASS
// class Animal
// {
//     // virtual → allows child classes to override this method
//     public virtual void Speak()
//     {
//         Console.WriteLine("Animal makes a sound");
//     }
// }

// // CHILD CLASS using override (REAL polymorphism)
// class Dog : Animal
// {
//     // override → replaces base class implementation
//     public override void Speak()
//     {
//         Console.WriteLine("Dog barks");
//     }
// }

// // CHILD CLASS using new (method hiding, NOT polymorphism)
// class Cat : Animal
// {
//     // new → hides base method, does NOT override it
//     public new void Speak()
//     {
//         Console.WriteLine("Cat meows");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Animal a1 = new Dog();
//         a1.Speak();    // Dog barks → runtime polymorphism

//         Animal a2 = new Cat();
//         a2.Speak();    // Animal makes a sound → base method called

//         Cat c = new Cat();
//         c.Speak();     // Cat meows → child method called
//     }
// }
