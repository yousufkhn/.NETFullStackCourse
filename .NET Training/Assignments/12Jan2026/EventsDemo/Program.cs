using System;

namespace EventsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Button btn = new Button();
            btn.Clicked += onTaskCompleted;

            btn.Click();
        }
    static void  onTaskCompleted()
        {
            System.Console.WriteLine("Clicked event handled");
        }
    }
}