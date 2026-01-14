using System;

namespace CollectionDemo
{
    class Program
    {
        public static void ArrayDemoFunc()
        {
            string[] empNames = {"Yousuf","Aryan","Dev","Aaysha"};
            Array.Sort(empNames);

            foreach(string s in empNames)
            {
                System.Console.WriteLine($"{s}");
            }
        }
        public static void Main(string[] args)
        {
            ArrayDemoFunc();
        }
    }
}