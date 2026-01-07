using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegatesDemo
{
    // delegates can be defined at namespace level as well or in class
    // Multicast delegate ( when return type is void)
    public delegate void GreetMsg(string msg);

    // Unicast Delegate
    public delegate int Calculation(string msg);

    class Hindi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhat " + userName);
        }
    }

    class Tamil
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Vanakkam " + userName);
        }
    }

    class Telugu
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskaram " + userName);
        }

    }

    class Marathi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskar " + userName);
        }

    }
    public class DelegateDemo
    {
        public static void DelegateDemoMain()
        {
            Tamil tObj = new Tamil();
            GreetMsg GreetInTamil = new GreetMsg(tObj.WelcomeMsg);

            GreetInTamil("Hello");
        }
    }
}
