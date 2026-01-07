// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num1 = 100;
int num2 = 200;
int numResult = num1+num2;

Employee emp1 = new Employee();
emp1.EmpID = 101;
emp1.EmpName= "alok";
emp1.BSalary = 4000;

Employee emp2 = new Employee();
emp2.EmpID = 102;
emp2.EmpName= "riya";
emp2.BSalary = 35000;

Employee emp3 = new Employee();
emp3.EmpID = 104;
emp3.EmpName= "riyaaaa";
emp3.BSalary = 35000;

Employee empObj = emp1 + emp2 + emp3;
System.Console.WriteLine(empObj.BSalary);