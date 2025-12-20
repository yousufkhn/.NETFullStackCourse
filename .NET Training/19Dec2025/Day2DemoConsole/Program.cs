// See https://aka.ms/new-console-template for more information
using Day2DemoConsole;

static void Menu()
{
    Console.WriteLine("1. Add Student Details");
    Console.WriteLine("2. Update Student Details");
    Console.WriteLine("3. Delete Student Details");

}

Console.WriteLine("Hello, World!");


Student sObj = new Student(123,"Yousuf","Jalandhar");

sObj.DisplayDetails(sObj);

sObj = new Student(123,"Alok","Chennai"); // this will create a new object, didn't manipulate the last object, memory overhead

sObj.DisplayDetails(sObj);

string[] cities = {"Pune","Chennai","Agra","Amritsar","Mumbai"};

// int i =0;
// while(i < cities.Length)
// {
//     Console.WriteLine(cities[i]);
//     i++;
// }

// foreach(var city in cities)
// {
//     Console.WriteLine(city);
// }


int choice = 0;
do
{
    
Menu();
Console.WriteLine("Enter your Choice: ");
choice = Int32.Parse(Console.ReadLine());
switch(choice)
{
    case 1:
        {
            Console.WriteLine("Your clicked on option 1!");
            break;
        }
    case 2:
        {
            Console.WriteLine("Your clicked on option 2!");
            break;
        }
    case 3:
        {
            Console.WriteLine("Your clicked on option 3!");
            break;
        }
}
}while(true);


