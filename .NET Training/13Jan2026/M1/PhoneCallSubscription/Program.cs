using System;

namespace PhoneCallSub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhoneCall ph = new PhoneCall();

            ph.MakeAPhoneCall(true);
            System.Console.WriteLine(ph.Message);

            ph.MakeAPhoneCall(false);
            System.Console.WriteLine(ph.Message);
        }
    }
}