// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using StudentManagementSystem;

StudentBL sBLobj = new StudentBL();
sBLobj.AcceptStudentDeatils();
// sBLobj.CalculateTotal();
// sBLobj.CalculateAvg();
int t1; // total
float p1; // percentage
sBLobj.calculateResult(out t1,out p1);


// System.Console.WriteLine($"Total { sBLobj.CalculateTotal()} and Percentage {sBLobj.CalculateAvg() }");
System.Console.WriteLine($"Total { t1} and Percentage {p1 }");


