using System;

namespace CounterSpace
{
    public class Program
    {
        static public void Main(string[] args)
        {
            int[] arr = {0,1,1,1,0};
            Counter counterObj = new Counter(arr);

            try
            {
                string output = counterObj.getCount();
                System.Console.WriteLine(output);
            }
            catch(ExceptionZero e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch(ExceptionOne e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}