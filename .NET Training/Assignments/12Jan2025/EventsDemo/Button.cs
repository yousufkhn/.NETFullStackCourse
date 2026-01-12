using System;

namespace EventsDemo
{
    public class Button
    {
        public event Action Clicked;

        public void Click()
        {
            System.Console.WriteLine("Button Clicked");

            if (Clicked != null)
            {
                Clicked();   // safe direct call
            }
        }
    }

}