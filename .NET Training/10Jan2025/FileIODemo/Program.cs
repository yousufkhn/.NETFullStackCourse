// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

DirectoryDemo dObj = new DirectoryDemo();
// dObj.DirectoryDemoFunc("LPU");

// single slash needed here, but it won't work, we need two slash, single slash is identified as escape sequence
// dObj.DriveInfoFunc("C:\\");

// dObj.PathDemoFunc();

FileStreamDemo fsDemoObj = new FileStreamDemo();
fsDemoObj.CreateFile(@"D:\MyData\Capgemini\Training\.NET Training\10Jan2025\SampleData.txt");

fsDemoObj.ReadFile(@"D:\MyData\Capgemini\Training\.NET Training\10Jan2025\SampleData.txt");

